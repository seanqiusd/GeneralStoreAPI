using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class StoreDbContext : DbContext  // we made StoreDbContext 
    {

        public StoreDbContext()  : base("DefaultConnection") // base name is what we named the connectionString in Web.config
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}