using UserManager.Entities;
using UserManager.Repositories;
using UserManager.ViewModels.Contacts;
using System.Web.Mvc;
using UserManager.Filters;

namespace UserManager.Controllers
{
    [AuthenticationFilter]
    public class ContactsController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactsRepository repo = new ContactsRepository();

            User loggedUser = (User)Session["loggedUser"];

            IndexVM model = new IndexVM();
            model.Items = repo.GetContacts(loggedUser.Id);

            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            User loggedUser = (User)Session["loggedUser"];
            ContactsRepository repo = new ContactsRepository();

            Contact item = id == null ? new Contact() : repo.GetById(id.Value);

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.UserId = loggedUser.Id;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Email = item.Email;

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditVM model)
        {
            User loggedUser = (User)Session["loggedUser"];
            ContactsRepository repo = new ContactsRepository();

            Contact item = new Contact();
            item.Id = model.Id;
            item.UserId = loggedUser.Id;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Email = model.Email;

            repo.Insert(item);

            return RedirectToAction("Index", "Contacts");
        }

        public ActionResult Delete(int id)
        {
            ContactsRepository repo = new ContactsRepository();
            repo.Delete(id);

            return RedirectToAction("Index", "Contacts");
        }
    }
}