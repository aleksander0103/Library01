using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserManager.Entities
{
    [Table("Books")]
    public class Book
    {
        public int Id { get; set; }        
        public string Title { get; set; }
        public string Author { get; set; }

    }
}