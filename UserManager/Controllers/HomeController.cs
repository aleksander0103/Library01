using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManager.Repositories;
using UserManager.ViewModels.Home;

namespace UserManager.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting =
            hour < 12
            ? "Good Morning. Time is" + DateTime.Now.ToShortTimeString()
            : "Good Afternoon. Time is " + DateTime.Now.ToShortTimeString();
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            LoginVM model = new LoginVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {

            if (!ModelState.IsValid)
                return View(model);

            UserRepository repo = new UserRepository();
            Session["loggedUser"] = repo.GetUsernameAndPassword(model.Username, model.Password);

            if (Session["loggedUser"] == null)
                ModelState.AddModelError("AuthenticationFailed", "Authentication Failed !!!!!!!");

            if (!ModelState.IsValid)
                return View(model);


                return RedirectToAction("Index", "Home");
        }
        public ActionResult Logout()
        {
            Session["loggedUser"] = null;
            return RedirectToAction("Login", "Home");
        }
    }
}