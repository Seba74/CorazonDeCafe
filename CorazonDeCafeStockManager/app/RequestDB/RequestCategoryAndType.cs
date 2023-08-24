using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace CorazonDeCafeStockManager
{
    internal class RequestCategoryAndType
    {
        private readonly ConnectMySQL connectionSql;

        public RequestCategoryAndType()
        {
            connectionSql = new ConnectMySQL();
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new();
            string query = "SELECT * FROM categorias";
            MySqlCommand command = new(query, connectionSql.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Category category = new()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Descripcion = reader.GetString(2),
                    Activo = reader.GetString(3)
                };
                categories.Add(category);
            }
            connectionSql.CloseConnection();
            return categories;
        }

        public List<Tipo> GetTypes()
        {
            List<Tipo> types = new();
            string query = "SELECT * FROM tipos";
            MySqlCommand command = new(query, connectionSql.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Tipo type = new()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Descripcion = reader.GetString(2),
                    Activo = reader.GetString(3)
                };
                types.Add(type);
            }
            connectionSql.CloseConnection();
            return types;
        }

    }
}
