﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using wingtipToys1.Models;

namespace wingtipToys1
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool GetProducts([QueryString("productID")] int? productId)
        {
            var _db = new wingtipToys1.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if(productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.ProductID == productId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}