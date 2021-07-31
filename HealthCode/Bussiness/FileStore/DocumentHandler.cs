using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.FileStore
{
    public class DocumentHandler
    {
        public static string Save(HttpPostedFileBase httpPostedFileBase)
        {
            string FileNameFormat = string.Empty;

            string guid = Guid.NewGuid().ToString();
            if(httpPostedFileBase == null)
            {
                return string.Empty;
            }

            string GetExtention = httpPostedFileBase.FileName.Split('.')[1];

            FileNameFormat = guid + "." + GetExtention;

            string PathLocation = HttpContext.Current.Server.MapPath("~/Images/HomeCollectionDocs/" + FileNameFormat);

            httpPostedFileBase.SaveAs(PathLocation);

            return FileNameFormat;
        }
    }
}