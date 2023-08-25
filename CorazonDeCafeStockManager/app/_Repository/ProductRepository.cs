using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CorazonDeCafeStockManager.app._Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ConnectMySQL connectionSql;

        public ProductRepository()
        {
            connectionSql = new ConnectMySQL();
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            List<Product> products = new();
            string query = "SELECT * FROM products";

            if (filter != "")
            {
                if (int.TryParse(filter, out int intFilter))
                {
                    query += " WHERE id LIKE '%" + intFilter + "%'";
                }
                else
                {
                    query += " WHERE nombre LIKE '%" + filter + "%'";
                }
            }

            MySqlCommand command = new(query, connectionSql.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product product = new()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Precio = reader.GetFloat(2),
                    Categoria_Id = reader.GetInt32(4),
                    Tipo_Id = reader.GetInt32(5),
                    Estado = reader.GetString(6),
                    Stock = reader.GetInt32(7),
                };
                products.Add(product);
            }
            connectionSql.CloseConnection();
            return products;
        }

        public void AddProduct(Product product)
        {
            string query = "INSERT INTO products (nombre, precio, categoria_id, tipo_id, estado, stock) VALUES (@nombre, @precio, @imagen, @categoria_id, @tipo_id, @estado, @stock)";
            MySqlCommand command = new(query, connectionSql.GetConnection());

            command.Parameters.AddWithValue("@nombre", product.Nombre);
            command.Parameters.AddWithValue("@precio", product.Precio);
            command.Parameters.AddWithValue("@imagen", product.Imagen);
            command.Parameters.AddWithValue("@categoria_id", product.Categoria_Id);
            command.Parameters.AddWithValue("@tipo_id", product.Tipo_Id);
            command.Parameters.AddWithValue("@estado", product.Estado);
            command.Parameters.AddWithValue("@stock", product.Stock);

            command.ExecuteNonQuery();
            connectionSql.CloseConnection();
        }

        public Product GetProduct(int id)
        {
            // query
            string query = "SELECT * FROM products WHERE id = @id";
            MySqlCommand command = new(query, connectionSql.GetConnection());

            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = command.ExecuteReader();

            Product product = new()
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Precio = reader.GetFloat(2),
                Imagen = reader.GetString(3),
                Categoria_Id = reader.GetInt32(4),
                Tipo_Id = reader.GetInt32(5),
                Estado = reader.GetString(6),
                Stock = reader.GetInt32(7),
            };
            return product;
        }

        public void UpdateProduct(Product product)
        {
            string query = "UPDATE products SET nombre = @nombre, precio = @precio, imagen = @imagen, categoria_id = @categoria_id, tipo_id = @tipo_id, estado = @estado, stock = @stock WHERE id = @id";

            MySqlCommand command = new(query, connectionSql.GetConnection());

        }

        public void DeleteProduct(int id)
        {
            string query = "DELETE FROM products WHERE id = @id";
            MySqlCommand command = new(query, connectionSql.GetConnection());

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connectionSql.CloseConnection();
        }
    }
}