using Proveedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proveedores.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SOAP(string id)
        {
            ProveedorContext cont = new ProveedorContext();
            Soap elsoap = new Soap();
            elsoap.Id = Guid.NewGuid();
            elsoap.JSON = id;
            cont.Soaps.Add(elsoap);
            if (cont.SaveChanges() == 1)
                ViewBag.elsoap = "success";
            else
                ViewBag.elsoap = "this shit failed";
            return View();
        }
	}
}