using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManager.Entities;
using UserManager.Repositories;

namespace UserManager.Controllers
{
    public class PhonesController : Controller
    {
        // GET: Phones
        public ActionResult Index()
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");
            PhonesRepository repo = new PhonesRepository();
            List<Phone> items = repo.GetAll();
            ViewData["items"] = items;

            return View();
        }
    }
}