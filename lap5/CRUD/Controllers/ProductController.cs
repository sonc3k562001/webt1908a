using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductEntities _context = new ProductEntities();

        [HttpPost]
        [Authorize]
        [Route("api/Product/Create")]
        public IHttpActionResult Create(ProductModel productModel)
        {
            var bank = new Product()
            {
                Name = productModel.Name,
                Category = productModel.Category,
                Qty = productModel.Qty
            };
            _context.Products.Add(bank);
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpGet]
        [Authorize]
        [Route("api/Product/GetAll")]
        public IHttpActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpPut]
        [Authorize]
        [Route("api/Product/Modify")]
        public IHttpActionResult Modify(ProductModel productModel)
        {
            var product = new Product()
            {
                Name = productModel.Name,
                Category = productModel.Category,
                Qty = productModel.Qty
            };

            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpDelete]
        [Authorize]
        [Route("api/Product/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var product = _context.Products.SingleOrDefault(e => e.Id == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok("Success");
        }
    }
}
