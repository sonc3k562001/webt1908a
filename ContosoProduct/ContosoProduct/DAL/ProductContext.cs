using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoProduct.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoProduct.DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTime> ProductTimes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}