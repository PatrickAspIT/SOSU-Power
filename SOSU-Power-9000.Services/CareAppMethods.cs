﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSU_Power_9000.Services
{
    public class CareAppMethods
    {
        public async Task<string> GetNameByIdAsync(string id)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SOSU-Power-9000Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Employee WHERE EmployeeId = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open(); // Synchronous open
                        object result = command.ExecuteScalar(); // Synchronous execute

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return null; // ID not found
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        return null;
                    }
                }
            }
        }
    }
}
