using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserManager.Entities;

namespace UserManager.Repositories
{
    public class PricesRepository
    {
        public Price GetById(int id)
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Prices.Where(i => i.BookId == id).FirstOrDefault();
        }
        public List<Price> GetAll()
        {
            UserManagerDbContext context = new UserManagerDbContext();
            return context.Prices.ToList();
        }
        /*---------------------------------------*/
        
    }
}