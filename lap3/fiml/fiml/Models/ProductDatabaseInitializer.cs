using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace fiml.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                   CategoryID = 1,
                   CategoryName = "Anime"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "horror "
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName ="Dramas"
                },
                new Category
                {
                    CategoryID= 5,
                    CategoryName ="Science fiction"
                }
            };
            return categories;
        }

    private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID =1 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =1
                },
                new Product
                {
                    ProductID =2 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =1
                },
                new Product
                {
                    ProductID =3 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =1
                },
                new Product
                {
                    ProductID =4 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =1
                },
                new Product
                {
                    ProductID =5 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =1
                },
                new Product
                {
                    ProductID =6 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =2
                },
                new Product
                {
                    ProductID =7 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =3
                },
                 new Product
                {
                    ProductID =8 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =4
                },
                  new Product
                {
                    ProductID =9 ,
                    ProductName = "Naruto",
                    Description="This is a series anime",
                    ImagePath = "Naruto.png",
                    UnitView= 12924239,
                    CategoryID =5
                },

            };
            return products;
        }
    } 
}