using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.Entity
{
    public class CartItem
    {
        public int IsExist { get; set; }
        public int Total { get; set; }

        public CartItem()
        {
            this.IsExist = 0;
            this.Total = 0;
        }
    }
}