using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserManager.Entities
{
    public class Price
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int BookPrice { get; set; }

    }
}