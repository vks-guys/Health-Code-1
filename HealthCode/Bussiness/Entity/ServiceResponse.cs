using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.Entity
{
    public class ServiceResponse
    {
        public int Id { get; set; }
        public int IsError { get; set; }
        public string ErrorMessage { get; set; }
    }
}