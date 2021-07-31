using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthCode.Bussiness.XmlGenerator
{
    public class XmlFile
    {
        public static string XmlData(string data)
        {
            string v_XML = "<NewDataSet>";
            var objContactPersonsList = JArray.Parse(data);
            if (objContactPersonsList != null)
            {
                if (objContactPersonsList.Count > 0)
                {
                    foreach (var Item in objContactPersonsList)
                    {
                        dynamic objContactPersons = JObject.Parse(Item.ToString());
                        if (Item.HasValues)
                        {
                            v_XML += "<tblCartTestOrPackage>"
                                                    + "<TestOrPackageId>" + objContactPersons.Id.ToString() + "</TestOrPackageId>"
                                                    + "<Price>" + objContactPersons.Price.ToString() + "</Price>"
                                   + "</tblCartTestOrPackage>";
                        }
                    }
                }

            }
            v_XML += "</NewDataSet>";

            return v_XML;
        }
    }
}