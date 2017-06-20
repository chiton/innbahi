using INNBAHI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace INNBAHI.Helpers
{
    public class DataRepository
    {
        public static List<Product> GetProducts()
        {
            using (StreamReader r = new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/products.json")))
            {
                string json = r.ReadToEnd();
                var products = JsonConvert.DeserializeObject<List<Product>>(json);

                return products;
            }
        }
    }
}