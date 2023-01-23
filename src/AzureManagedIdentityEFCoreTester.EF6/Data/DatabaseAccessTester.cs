using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagedIdentityEFCoreTester.EF6.Data
{
    public class DatabaseAccessTester
    {
        private readonly string connectionString;

        public DatabaseAccessTester(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Checks this instance.
        /// </summary>
        public void TestDbConnection()
        {
            using (var dbContext = new ApplicationDbContext(connectionString))
            {
                var result = dbContext.Database.ExecuteSqlRaw("SELECT 1");
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
