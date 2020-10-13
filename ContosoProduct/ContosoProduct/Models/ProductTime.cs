using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoProduct.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class ProductTime
    {
        public int ProductTimeID { get; set; }
        public int CategoryID { get; set; }
        public int ProductID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}