using INNBAHI.Helpers;
using INNBAHI.ViewModels;
using System.Web.Mvc;

namespace INNBAHI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Select(string productKey)
        {
            var products = DataRepository.GetProducts();
            var product = products.Find(p => p.Key == productKey);

            return View(new ProductDetails()
            {
                Products = products,
                Product = product
            });
        }
    }
}