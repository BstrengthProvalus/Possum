using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PossumProject.Controllers
{
    public class InventoryController : Controller
    {
        InventoryEntities db = new InventoryEntities();

        public ActionResult Index()
        {
            return View(db.Inventories.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                db.Inventories.Add(inventory);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(inventory);
        }
    }
}