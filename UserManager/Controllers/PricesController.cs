using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManager.Entities;
using UserManager.Repositories;

namespace UserManager.Controllers
{
    public class PricesController : Controller
    {
        // GET: Prices
        public ActionResult Index()
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");
            PricesRepository repo = new PricesRepository();
            List<Price> items = repo.GetAll();
            ViewData["items"] = items;
            return View();
        }
    }
}