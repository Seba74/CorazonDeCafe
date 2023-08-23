using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace CorazonDeCafeStockManager
{
    internal class RequestProducts
    {
        private readonly ConnectMySQL connectionSql;

        public RequestProducts()
        {
            connectionSql = new ConnectMySQL();
        }

        public List<Product> GetProducts(string filter)
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
    }
}
