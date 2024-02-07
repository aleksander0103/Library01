using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using UserManager.Entities;

namespace UserManager.Repositories
{
    public class UserRepository
    {
        

        public User GetById(int id)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Users.Where(i => i.Id == id).FirstOrDefault();
        }



        public List<User> GetAll()
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Users.ToList();
        }



        public void Insert(User item)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            context.Users.Add(item);
            context.SaveChanges();
        }



        public void Update(User item)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }



        public void Delete(int id)
        {
            UserManagerDbContext context = new UserManagerDbContext();
           User item = context.Users.Where(i => i.Id == id).FirstOrDefault();
            context.Users.Remove(item);
            context.SaveChanges();

        }

        public void Save(User item)
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

        public User GetUsernameAndPassword(string username, string password)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Users.Where(i => i.Username == username && i.Password == password).FirstOrDefault();
        }
    }
}