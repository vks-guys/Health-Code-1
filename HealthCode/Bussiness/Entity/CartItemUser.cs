using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.Entity
{
    public class CartItemUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string XMLCartItem { get; set; }
    }
}