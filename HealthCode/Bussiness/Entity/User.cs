using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IsPlatform { get; set; }
        public string UserName { get; set; }
    }
}