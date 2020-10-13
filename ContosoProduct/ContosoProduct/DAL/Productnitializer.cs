using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoProduct.Models;

namespace ContosoProduct.DAL
{
    public class Productnitializer :System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
                new Product{Name ="Iphone1",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
                new Product{Name ="Iphone2",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
                new Product{Name ="Iphone3",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
                new Product{Name ="Iphone4",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
                new Product{Name ="Iphone5",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
                new Product{Name ="Iphone6",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
                new Product{Name ="Iphone7",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
                new Product{Name ="Iphone8",Description="The Smarphone new",ProductTime = DateTime.Parse("2001-08-01")},
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var categorys = new List<Category>
            {
                new Category{CategoryID=1050,Title="IOS",Creadits=3,},
                new Category{CategoryID=4022,Title="IOS",Creadits=3,},
                new Category{CategoryID=4041,Title="IOS",Creadits=3,},
                new Category{CategoryID=1045,Title="IOS",Creadits=4,},
                new Category{CategoryID=3141,Title="IOS",Creadits=4,},
                new Category{CategoryID=2021,Title="IOS",Creadits=3,},
                new Category{CategoryID=2042,Title="IOS",Creadits=4,},
            };
            categorys.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var productTimes = new List<ProductTime>
            {
                new ProductTime { ProductID = 1, CategoryID = 1050, Grade = Grade.A },
                new ProductTime { ProductID = 1, CategoryID = 4022, Grade = Grade.C },
                new ProductTime { ProductID = 1, CategoryID = 4041, Grade = Grade.B },
                new ProductTime { ProductID = 2, CategoryID = 1045, Grade = Grade.B },
                new ProductTime { ProductID = 2, CategoryID = 3141, Grade = Grade.F },
                new ProductTime { ProductID = 2, CategoryID = 2021, Grade = Grade.F },
                new ProductTime { ProductID = 3, CategoryID = 1050,},
                new ProductTime { ProductID = 4, CategoryID = 1050,},
                new ProductTime { ProductID = 4, CategoryID = 4022, Grade = Grade.F },
                new ProductTime { ProductID = 5, CategoryID = 4041, Grade = Grade.C },
                new ProductTime { ProductID = 6, CategoryID = 1045 },
                new ProductTime { ProductID = 7, CategoryID = 3141, Grade = Grade.A },
            };
            productTimes.ForEach(s => context.ProductTimes.Add(s));
            context.SaveChanges();
        }
    }
}