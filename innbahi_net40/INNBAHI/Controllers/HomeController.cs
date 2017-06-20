using INNBAHI.Helpers;
using INNBAHI.ViewModels;
using System.Web.Mvc;

namespace INNBAHI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var products = DataRepository.GetProducts();

            return View(new BaseViewModel()
            {
                Products = products
            });
        }
    }
}