using BlazorEntity;
using Dapper;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BlazorDataAccess
{
    public class SqlDataAccess:ISqlDataAccess
    {
        public async Task<List<Product>> GetProducts()
        {
            string connectionString = "";

            using (var connection=new SqlConnection(connectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<Product>("SELECT * FROM Product");

                return result.ToList();
            }
        }
    }
}
