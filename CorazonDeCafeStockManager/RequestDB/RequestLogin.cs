using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace CorazonDeCafeStockManager
{
    internal class RequestLogin
    {
        private readonly ConnectMySQL connectionSql;

        public RequestLogin()
        {
            connectionSql = new ConnectMySQL();
        }

        public bool Login(string user, string password)
        {
            string query = "SELECT pass FROM usuarios WHERE usuario = '" + user + "'";
            MySqlCommand command = new MySqlCommand(query, connectionSql.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string pass = reader.GetString(0);
                if(pass == password)
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }
    }
}
