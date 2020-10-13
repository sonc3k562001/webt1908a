using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoProduct.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public int Creadits { get; set; }

        public virtual ICollection<ProductTime> ProductTimes { get; set; }
    }
}