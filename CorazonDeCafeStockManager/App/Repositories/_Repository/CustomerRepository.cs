using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class CustomerRepository : ICustomerRepository
{

    private readonly CorazonDeCafeContext _context;

    public CustomerRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    private async Task LoadCategoriesAndTypes()
    {
        try
        {
            await _context.Categories!.LoadAsync();
            await _context.Types!.LoadAsync();


            LocalStorage.Categories = await _context.Categories!.ToListAsync();
            LocalStorage.Types = await _context.Types!.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public async Task AddCustomer(Customer customer)
    {
        if (customer == null)
        {
            throw new ArgumentNullException(nameof(customer));
        }

        await _context.Customers!.AddAsync(customer);

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        LocalStorage.Customers!.Add(customer);
    }

    public async Task<bool> DeleteCustomer(int id)
    {
        Customer? customer = await _context.Customers!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id);
        if (customer == null) return false;
        customer.User.Status = 0;
        try
        {
            int isDeleted = await _context.SaveChangesAsync();
            if (isDeleted > 0) LocalStorage.Customers!.Remove(customer);

            return isDeleted > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<IEnumerable<Customer>> GetAllCustomers()
    {
        if (LocalStorage.Categories == null || LocalStorage.Types == null)
            await LoadCategoriesAndTypes();
        // if is empty
        if (!LocalStorage.Customers.IsNullOrEmpty()) return LocalStorage.Customers!;

        try
        {
            LocalStorage.Customers = await _context.Customers!.Include(p => p.User).Where(p => p.User.Status == 1).ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return LocalStorage.Customers ?? new();
    }
    public async Task<Customer> GetCustomerById(int id)
    {
        Customer? customer = await _context.Customers!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id) ?? throw new ArgumentException("Customer not found");
        return customer;
    }

    public async Task<bool> UpdateCustomer(Customer customer)
    {
        Customer? customerToUpdate = await _context.Customers!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == customer.Id);

        if (customerToUpdate == null)
        {
            return false;
        }

        customerToUpdate.User.Name = customer.User.Name;
        customerToUpdate.User.Surname = customer.User.Surname;
        customerToUpdate.User.Email = customer.User.Email;
        customerToUpdate.User.Phone = customer.User.Phone;
    
        int fieldAct = await _context.SaveChangesAsync();
        return fieldAct > 0;
    }
}

