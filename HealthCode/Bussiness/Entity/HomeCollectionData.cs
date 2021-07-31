using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.Entity
{
    public class HomeCollectionData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HouseNo { get; set; }
        public string Floor { get; set; }
        public string Coloni { get; set; }
        public string Landmark { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string SelectPreferredDate { get; set; }
        public string SelectPrefferedTime { get; set; }
        public string Message { get; set; }
        public string FileLocation { get; set; }
        public HttpPostedFileBase FormFile { get; set; }
    }
}