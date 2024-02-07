using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserManager.Entities;

namespace UserManager.Repositories
{
    public class BooksRepository
    {
        public Book GetById(int id)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Books.Where(i => i.Id == id).FirstOrDefault();
        }
        public List<Book> GetAll()
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Books.ToList();
        }

        public void Insert(Book item)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            context.Books.Add(item);
            context.SaveChanges();
        }
        public void Update(Book item)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            Book item = context.Books.Where(i => i.Id == id).FirstOrDefault();
            context.Books.Remove(item);
            context.SaveChanges();
        }

        public void Save(Book item)
        {
            if (item.Id > 0)
            {
                Update(item);
            }
            else
            {
                Insert(item);

            }

        }

        /*---------------------------------------*/

        public Book GetTitleAndAuthor(string title, string author)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Books.Where(i => i.Title == title && i.Author == author).FirstOrDefault();
        }
    }
}