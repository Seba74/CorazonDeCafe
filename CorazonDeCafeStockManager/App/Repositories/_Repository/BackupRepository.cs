using CorazonDeCafeStockManager.App.Models;
using CorazonDeCafeStockManager.App.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class BackupRepository : IBackupRepository
{
    private readonly CorazonDeCafeContext? _context;

    public BackupRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    public async Task<bool> Backup(string database, string path)
    {
        try
        {
            string contextDatabaseName = _context!.Database.GetDbConnection().Database;

            if (!string.Equals(database, contextDatabaseName, StringComparison.OrdinalIgnoreCase))
            {
                throw new LocalException($"La base de datos {database} no es la misma que la base de datos actual {contextDatabaseName}");
            }

            if (!Directory.Exists(path)) throw new LocalException($"La ruta {path} no existe");

            string backupNumberFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backupcfc.bin");
            int backupcfc = 1;
            DateTime lastBackupDate = DateTime.MinValue;

            if (File.Exists(backupNumberFilePath))
            {
                using FileStream stream = new(backupNumberFilePath, FileMode.Open);
                BinaryReader reader = new(stream);
                lastBackupDate = DateTime.FromBinary(reader.ReadInt64());
                backupcfc = reader.ReadInt32() + 1;
            }

            if (DateTime.Today != lastBackupDate.Date)
            {
                backupcfc = 1;
            }

            string backupFileName = $"{database}-{DateTime.Now:dd-MM-yyyy}-{backupcfc}.bak";
            string backupFilePath = Path.Combine(path, backupFileName);

            if (File.Exists(backupFilePath)) throw new LocalException($"Ya existe un archivo con el nombre {backupFileName}");

            string query = $"BACKUP DATABASE {database} TO DISK = '{backupFilePath}'";
            await _context!.Database.ExecuteSqlRawAsync(query);

            using (FileStream stream = new(backupNumberFilePath, FileMode.Create))
            {
                BinaryWriter writer = new(stream);
                writer.Write(DateTime.Today.ToBinary());
                writer.Write(backupcfc);
            }
            return true;
        }
        catch (LocalException ex)
        {
            throw new LocalException(ex.Message);
        }
        catch (Exception)
        {
            throw new LocalException("Error al realizar el respaldo de la base de datos");
        }
    }

    public async Task<bool> Restore(string database, string path)
    {
        try
        {
            string contextDatabaseName = _context!.Database.GetDbConnection().Database;
            if (!string.Equals(database, contextDatabaseName, StringComparison.OrdinalIgnoreCase))
            {
                throw new LocalException($"La base de datos {database} no es la misma que la base de datos actual {contextDatabaseName}");
            }

            string query = "USE MASTER RESTORE DATABASE @database FROM DISK = @path WITH REPLACE";
            SqlParameter[] parameters = new SqlParameter[] { new("@database", database), new("@path", path) };

            await _context!.Database.ExecuteSqlRawAsync(query, parameters);
            await _context.Database.MigrateAsync();

            _context.ChangeTracker.Clear();

            LocalStorage.Products = null;
            LocalStorage.Categories = null;
            LocalStorage.Types = null;
            LocalStorage.Employees = null;
            LocalStorage.Customers = null;

            return true;
        }
        catch (SqlException)
        {
            throw new LocalException("Error al restaurar la base de datos");
        }
        catch (Exception ex)
        {
            throw new LocalException(ex.Message);
        }
    }

    public string GetUbication(bool getFile)
    {
        try
        {
            if (!getFile)
            {
                FolderBrowserDialog folderBrowserDialog = new();
                folderBrowserDialog.ShowDialog();
                return folderBrowserDialog.SelectedPath;
            }

            OpenFileDialog openFileDialog = new()
            {
                Filter = "Backup files (*.bak)|*.bak",
                Title = "Seleccionar archivo",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) return openFileDialog.FileName;
            return string.Empty;
        }
        catch (Exception)
        {
            throw new LocalException("Error al obtener la ubicación");
        }
    }
}

