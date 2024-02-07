using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManager.Entities;
using UserManager.Repositories;
using UserManager.ViewModels.Books;

namespace UserManager.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");

            BooksRepository repo = new BooksRepository();
            List<Book> items = repo.GetAll();

            ViewData["items"] = items;

            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");

            BooksRepository repo = new BooksRepository();
            Book item = id == null ? new Book() : repo.GetById(id.Value);
            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Title = item.Title;
            model.Author = item.Author;            
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
            { return View(model); }

            BooksRepository repo = new BooksRepository();
            Book item = new Book();
            item.Id = model.Id;
            item.Title = model.Title;
            item.Author = model.Author;           
            repo.Save(item);

            return RedirectToAction("Index", "User");
        }


        public ActionResult Delete(int id)
        {
            if (Session["loggedUser"] == null)
                return RedirectToAction("Login", "Home");

            BooksRepository repo = new BooksRepository();
            repo.Delete(id);

            return RedirectToAction("Index");
        }
    }
}