using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lap5.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
    }
}