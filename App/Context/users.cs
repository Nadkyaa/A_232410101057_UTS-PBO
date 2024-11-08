using A_1057_UTS_PBO.App.Core;
using A_1057_UTS_PBO.App.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1057_UTS_PBO.App.Context
{
    internal class users : DatabaseWrapper
    {
        private static string table = "users";
        private static object newpassword;

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataProdi = queryExecutor(query);
            return dataProdi;
        }

        public static void AddUsers(M_users newusers)
        {
            string query = $"INSERT INTO {table} (username) values (@username)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = newusers.Username},
            };
            commandExecutor(query, parameters);
        }
        public static void AddPassword(M_users newpassword)
        {
            string query = $"INSERT INTO {table} (password) values (@password)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar){Value = newpassword.Password}
            };
            commandExecutor(query, parameters);
        }
        
    }
}