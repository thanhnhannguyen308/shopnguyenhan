﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenNhanShop.Web.Models
{
    public class ShoppingCartViewModel
    {
   
        public int ProductId { set; get; }
        public ProductViewModel Product { set; get; }
        public int Quantity { set; get; }
    }
}