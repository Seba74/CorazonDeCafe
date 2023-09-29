using CorazonDeCafeStockManager.App.Common;
using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CorazonDeCafeStockManager.App.Repositories._Repository;

public class ProductRepository : IProductRepository
{

    private readonly CorazonDeCafeContext _context;

    public ProductRepository(CorazonDeCafeContext context)
    {
        _context = context;
    }

    private async Task LoadCategoriesAndTypes()
    {
        try
        {
            LocalStorage.Categories = await _context.Categories!.ToListAsync();
            LocalStorage.Types = await _context.Types!.ToListAsync();
        }
        catch (Exception)
        {
            throw new LocalException("Error al cargar las categorías y tipos");
        }
    }

    public async Task AddProduct(ProductData product)
    {
        try
        {
            if (await _context.Products!.AnyAsync(p => p.Imagen == product.Imagen && p.Name == product.Name)) throw new LocalException("Ya existe el producto");

            Product productToAdd = new()
            {
                Name = product.Name!,
                Price = product.Price,
                Stock = product.Stock,
                CategoryId = product.CategoryId,
                TypeId = product.TypeId,
                Active = product.Active,
                Status = product.Status,
                Imagen = product.Imagen!,
                CreatedById = (int)SessionManager.Id!
            };

            await _context.Products!.AddAsync(productToAdd);
            await _context.SaveChangesAsync();

            LocalStorage.Products!.Add(productToAdd);
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new Exception("No fue posible añadir el producto");
        }
    }

    public async Task<bool> DeleteProduct(int id)
    {
        try
        {
            Product productToDelete = await _context.Products!.FirstOrDefaultAsync(p => p.Id == id) ?? throw new LocalException("Producto no encontrado");
            productToDelete.Status = 0;
            int isDeleted = await _context.SaveChangesAsync();
            if (isDeleted > 0) LocalStorage.Products!.Remove(productToDelete);

            return isDeleted > 0;
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al eliminar el producto");
        }
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        try
        {
            if (LocalStorage.Categories.IsNullOrEmpty() || LocalStorage.Types.IsNullOrEmpty()) await LoadCategoriesAndTypes();
            if (!LocalStorage.Products.IsNullOrEmpty()) return LocalStorage.Products!;

            LocalStorage.Products = await _context.Products!.Include(p => p.Category).Include(p => p.Type).Where(p => p.Status == 1).ToListAsync();
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new Exception("Error al cargar los productos");
        }
        return LocalStorage.Products ?? new();
    }
    public async Task<Product> GetProductById(int id)
    {
        return await _context.Products!.FirstOrDefaultAsync(p => p.Id == id) ?? throw new LocalException("Producto no encontrado");
    }

    public async Task<bool> UpdateProduct(ProductData product)
    {
        try
        {
            Product productToUpdate = await _context.Products!.FirstOrDefaultAsync(p => p.Id == product.Id) ?? throw new LocalException("Producto no encontrado");

            productToUpdate!.Name = product.Name!;
            productToUpdate.Price = product.Price;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.TypeId = product.TypeId;
            productToUpdate.Stock = product.Stock;
            productToUpdate.Status = product.Status;
            productToUpdate.Imagen = product.Imagen!;
            productToUpdate.Active = product.Active;
            productToUpdate.UpdatedAt = DateTime.Now;
            productToUpdate.UpdatedById = SessionManager.Id;

            int fieldAct = await _context.SaveChangesAsync();
            if (fieldAct <= 0) throw new LocalException("No se pudo actualizar el producto");
            return true;
        }
        catch (LocalException e)
        {
            throw new LocalException(e.Message);
        }
        catch (Exception)
        {
            throw new ArgumentException("Error al actualizar el producto");
        }
    }
}

