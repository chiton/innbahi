using INNBAHI.Helpers;
using INNBAHI.ViewModels;
using System.Web.Mvc;

namespace INNBAHI.Controllers
{
    public class ProductController : Controller
    {
        private const string SoportesKey = "soportes";
        private const string ApostaderoKey = "apostadero";
        private const string SillonExtraccionesKey = "sillon_extracciones";
        private const string ReductorOxigenoKey = "reductor_oxigeno";
        private const string ElevadorPiscinasKey = "elevador_piscinas";
        private const string MovilizadorPacientesKey = "movilizador_pacientes";
        private const string OtrosKey = "otros_desarrollos";

        public ActionResult Soportes()
        {
            return CreateView(SoportesKey);
        }

        public ActionResult ReductorOxigeno()
        {
            return CreateView(ReductorOxigenoKey);
        }

        public ActionResult SillonExtracciones()
        {
            return CreateView(SillonExtraccionesKey);
        }

        public ActionResult Apostadero()
        {
            return CreateView(ApostaderoKey);
        }

        public ActionResult ElevadorPiscinas()
        {
            return CreateView(ElevadorPiscinasKey);
        }

        public ActionResult MovilizadorPacientes()
        {
            return CreateView(MovilizadorPacientesKey);
        }

        public ActionResult Otros()
        {
            return CreateView(OtrosKey);
        }

        private ActionResult CreateView(string key)
        {
            var products = DataRepository.GetProducts();
            var product = products.Find(p => p.Key == key);

            return View(new ProductDetails()
            {
                Products = products,
                Product = product
            });
        }
    }
}