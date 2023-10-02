using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Repositories;
using CorazonDeCafeStockManager.App.Views.BackupForm;

namespace CorazonDeCafeStockManager.App.Presenters
{
    public class BackupPresenter
    {
        private readonly IBackupView view;
        private readonly IBackupRepository repository;
        private readonly HomePresenter homePresenter;
        private bool isWithFile;

        public BackupPresenter(IBackupView view, IBackupRepository repository, HomePresenter homePresenter)
        {
            this.view = view;
            this.repository = repository;
            this.homePresenter = homePresenter;

            this.view.SaveEvent += SaveEvent;
            this.view.CancelEvent += CancelEvent;
            this.view.AddLocationEvent += AddLocationEvent;
            this.view.OptionChangedEvent += OptionChangedEvent;
            this.view.Show();
        }

        private void OptionChangedEvent(object? sender, System.EventArgs e)
        { }

        private void AddLocationEvent(object? sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(view.SelectedDatabase))
            {
                view.ShowError("Debe seleccionar una base de datos");
                return;
            }

            isWithFile = view.SelectedOption == "restaurar copia de seguridad";
            view.SelectedLocation = repository.GetUbication(isWithFile);
        }

        private async void SaveEvent(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(view.SelectedDatabase) || string.IsNullOrEmpty(view.SelectedLocation))
                {
                    view.ShowError("Debe completar todos los campos");
                    return;
                }

                if (isWithFile)
                {
                    try
                    {
                        await repository.Restore(view.SelectedDatabase, view.SelectedLocation);
                    }
                    catch (LocalException ex)
                    {
                        view.ShowError(ex.Message);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        await repository.Backup(view.SelectedDatabase, view.SelectedLocation);
                    }
                    catch (LocalException ex)
                    {
                        view.ShowError(ex.Message);
                        return;
                    }
                }
                homePresenter.ShowHomeView();
            }
            catch (LocalException ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void CancelEvent(object? sender, System.EventArgs e)
        {
            homePresenter.ShowHomeView();
        }
    }
}
