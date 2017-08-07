using INNBAHI.Helpers;
using INNBAHI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INNBAHI.Controllers
{
    public class MailController : Controller
    {
        //
        // GET: /Mail/

        public ActionResult Send(string email, string name, string phone, string message)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(message) || (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone)))
            {
                return View(new SendMail()
                {
                    Title = "Formulario incompleto",
                    Message = "Por favor ingrese el nombre, email o teléfono y mensaje.",
                    Products = DataRepository.GetProducts()
                });
            }

            Email.Send(
                    AppAettingsReader.EmailTo,
                    string.Format("Consulta de {0}", name),
                    string.Format("Nombre: {0}{1}Teléfono: {2}{1}Email: {3}{1}{1}{4}", name, Environment.NewLine, phone, email, message));

            return View(new SendMail()
            {
                Title = "Gracias por contactarnos",
                Message = "Hemos recibido su mail, nos pondremos en contacto con Ud. a la brevedad.",
                Products = DataRepository.GetProducts()
            });
        }

    }
}
