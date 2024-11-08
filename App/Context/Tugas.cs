using A_1057_UTS_PBO.App.Core;
using A_1057_UTS_PBO.App.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1057_UTS_PBO.App.Context
{   
    internal class Context : DatabaseWrapper
    {
        private static string table = "Tugas";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            t.id,
            t.judul,
            t.deskripsi,
            t.deadline
        FROM 
            tugas";

            DataTable tugas = queryExecutor(query);
            return tugas;
        }

        public static DataTable getTugasById(int id)
        {
            string query = @"
                SELECT 
            t.id,
            t.judul,
            t.deskripsi,
            t.deadline  
                FROM 
                    tugas";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable tugas = queryExecutor(query, parameters);
            return tugas;
        }


        public static void AddTugas(M_Tugas tugasBaru)
        {
            string query = $"INSERT INTO {table} (judul, deskripsi, deadline) VALUES(@judul, @deskripsi, @deadline)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul", tugasBaru.judul),
                new NpgsqlParameter("@deskripsi", tugasBaru.deskripsi),
                new NpgsqlParameter("@deadline", tugasBaru.deadline),
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateTugas(M_Tugas tugas)
        {
            {
                string query = $"INSERT INTO {table} (judul, deskripsi, deadline) VALUES(@judul, @deskripsi, @deadline)";

                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@judul", tugas.judul),
                new NpgsqlParameter("@deskripsi", tugas.deskripsi),
                new NpgsqlParameter("@deadline", tugas.deadline),
            };

                commandExecutor(query, parameters);
            }

        }
    }
}