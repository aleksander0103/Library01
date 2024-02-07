using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManager.Entities;
using UserManager.Repositories;
using UserManager.ViewModels.Users;

namespace UserManager.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");

            UserRepository repo = new UserRepository();
            List<User> items = repo.GetAll();

            ViewData["items"] = items;


            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");

            UserRepository repo = new UserRepository();
            User item = id == null ? new User() : repo.GetById(id.Value);
            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
            { return View(model); }

            UserRepository repo = new UserRepository();
            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;          
            repo.Save(item);

            return RedirectToAction("Index", "User");
        }


        public ActionResult Delete(int id)
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");

            UserRepository repo = new UserRepository();
            repo.Delete(id);

            return RedirectToAction("Index");
        }
    }
}