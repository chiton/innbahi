using INNBAHI.Helpers;
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

        public ActionResult Send(string email, string name, string message)
        {
            Email.Send(
                AppAettingsReader.EmailTo, 
                string.Format("Consulta de {0}",name),
                string.Format("Nombre: {0}{1}Email: {2}{1}{1}{3}", name, Environment.NewLine, email, message));

            return RedirectToAction("Index", "Home");
        }

    }
}
