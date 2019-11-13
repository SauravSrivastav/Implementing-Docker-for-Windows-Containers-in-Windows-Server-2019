using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using Dapper;

namespace WebApplication1
{
    public class CustomerRepository
    {
        private readonly string connectionString;

        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Customers LoadAllCustomers()
        {
            string sql = "SELECT Person as Name, NumDonuts as DonutCount from [MyApp].[dbo].[PersonDonuts]";
            using (var connection = new SqlConnection(connectionString))
            {
                var orders = connection.Query<Order>(sql).ToList();
                return new Customers
                {
                    Orders = orders
                };
            }
        }

    }
}