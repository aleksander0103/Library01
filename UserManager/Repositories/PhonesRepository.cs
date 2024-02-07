using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserManager.Entities;

namespace UserManager.Repositories
{
    public class PhonesRepository
    {
        public Phone GetById(int id)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Phones.Where(i => i.Id == id).FirstOrDefault();
        }
        public List<Phone> GetAll()
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Phones.ToList();
        }
        /*---------------------------------------*/
        
    }
}