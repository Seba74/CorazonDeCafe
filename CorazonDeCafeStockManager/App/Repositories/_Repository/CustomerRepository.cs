using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
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

    public async Task AddCustomer(CustomerData customer)
    {
        try
        {
            if (await _context.Users!.AnyAsync(p => p.Dni == customer.Dni)) throw new LocalException("Ya existe un cliente con ese DNI");
            if (await _context.Users!.AnyAsync(p => p.Email == customer.Email)) throw new LocalException("Ya existe un cliente con ese Email");

            Address address = new()
            {
                Street = customer.Street!,
                Number = customer.Number!,
                City = customer.City!,
                Province = customer.Province!,
                PostalCode = customer.PostalCode!,
            };

            await _context.Addresses!.AddAsync(address);
            await _context.SaveChangesAsync();

            User user = new()
            {
                Name = customer.Name!,
                Surname = customer.Surname!,
                Email = customer.Email!,
                Dni = customer.Dni!,
                Phone = customer.Phone,
                Status = customer.Status,
                AddressId = address.Id,
            };

            await _context.Users!.AddAsync(user);
            await _context.SaveChangesAsync();

            Customer customerToAdd = new()
            {
                UserId = user.Id,
            };

            await _context.Customers!.AddAsync(customerToAdd);
            await _context.SaveChangesAsync();

            LocalStorage.Customers!.Add(customerToAdd);
        }
        catch (LocalException e)
        {
            throw new ArgumentException(e.Message);
        }

        catch (Exception)
        {
            throw new ArgumentException("Error al agregar el cliente");
        }
    }

    public async Task<bool> DeleteCustomer(int id)
    {
        try
        {
            Customer? customer = await _context.Customers!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id) ?? throw new LocalException("No se encontró el cliente");
            customer.User.Status = 0;

            int isDeleted = await _context.SaveChangesAsync();
            if (isDeleted > 0) LocalStorage.Customers!.Remove(customer);
            else throw new LocalException("No se pudo eliminar el cliente");
            return true;
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al eliminar el cliente");
        }
    }

    public async Task<IEnumerable<Customer>> GetAllCustomers()
    {
        if (!LocalStorage.Customers.IsNullOrEmpty()) return LocalStorage.Customers!;

        try
        {
            LocalStorage.Customers = await _context.Customers!.Include(p => p.User).Include(p => p.User.Address).ToListAsync();
        }
        catch (Exception)
        {
            throw new LocalException("Error al obtener los clientes");
        }

        return LocalStorage.Customers ?? new();
    }
    public async Task<Customer> GetCustomerById(int id)
    {
        Customer? customer = await _context.Customers!.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id) ?? throw new LocalException("No se encontró el cliente");
        return customer;
    }

    public async Task<bool> UpdateCustomer(CustomerData customer)
    {
        try
        {
            Customer? customerToUpdate = await _context.Customers!.Include(p => p.User).Include(p => p.User.Address).FirstOrDefaultAsync(p => p.Id == customer.Id);
            if (customerToUpdate == null) return false;

            customerToUpdate.User.Name = customer.Name!;
            customerToUpdate.User.Surname = customer.Surname!;
            customerToUpdate.User.Email = customer.Email!;
            customerToUpdate.User.Phone = customer.Phone;
            customerToUpdate.User.Dni = customer.Dni!;
            customerToUpdate.User.Status = customer.Status;

            customerToUpdate.User.Address!.Street = customer.Street!;
            customerToUpdate.User.Address.Number = customer.Number!;
            customerToUpdate.User.Address.City = customer.City!;
            customerToUpdate.User.Address.Province = customer.Province!;
            customerToUpdate.User.Address.PostalCode = customer.PostalCode!;

            int fieldAct = await _context.SaveChangesAsync();
            if (fieldAct == 0) throw new LocalException("No se realizaron cambios");
            return true;
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al actualizar el cliente");
        }
    }
}

