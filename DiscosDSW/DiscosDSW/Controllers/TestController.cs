using DiscosDSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiscosDSW.Controllers
{

    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            Cliente c = new Cliente();
            c.Nombre = "Cliente 1";
            c.Email = "email 1";
            c.Password = "xxxxxx";
            ViewData["Cliente"] = c;
            return View("MyView");
        }
    }
}