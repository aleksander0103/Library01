using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserManager.ViewModels.Books
{
    public class EditVM
    {
        public int Id { get; set; }
        [DisplayName("Title:")]
        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }

        [DisplayName("Author:")]
        [Required(ErrorMessage = "This field is required!")]

        public string Author { get; set; }
    }  
}