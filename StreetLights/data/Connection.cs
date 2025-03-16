using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StreetLights.Data
{
    class Connection
    {
        public void Main2()
        {
            string connectionString = @"Server=(localdb)\StreetLightsDB;Database=master;Trusted_Connection=True;";
            string query = "SELECT * FROM Lamp";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["locatie"]);
                }
            }
        }
    }
}
