using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PossumProject.Controllers
{
    public class HomeController : Controller
    {
        InventoryEntities db = new InventoryEntities();

        public ActionResult Index()
        {
            return View(db.Inventories.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}