using INNBAHI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INNBAHI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Select(string product)
        {
            using (StreamReader r = new StreamReader(Server.MapPath("~/App_Data/products.json")))
            {
                string json = r.ReadToEnd();
                var products = JsonConvert.DeserializeObject<List<Product>>(json);

                //var model = products.Find(p => p.Name.Equals(product));
                var model = products.First();

                return View(model);
            }
        }
    }
}