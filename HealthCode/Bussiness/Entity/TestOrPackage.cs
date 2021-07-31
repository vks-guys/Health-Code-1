using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.Entity
{
    public class TestOrPackage
    {
        public int Id { get; set; }
        public string TestOrPackageName { get; set; }
        public int TestOrPackageType { get; set; }
        public decimal TestOrPackagePrice { get; set; }
        public string PreTestInformation { get; set; }
        public string DeliveryReport { get; set; }
        public string SampleRequired { get; set; }
        public string Description { get; set; }
    }
}