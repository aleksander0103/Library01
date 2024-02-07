using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserManager.ViewModels.Contacts
{
    public class EditVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }


        [DisplayName("First Name")]
        [Required(ErrorMessage = " Error!")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = " Error!")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = " Error!")]
        public string Email { get; set; }
    }
}