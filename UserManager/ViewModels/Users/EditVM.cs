﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserManager.ViewModels.Users
{
    public class EditVM
    {
        public int Id { get; set; }
        [DisplayName("Username:")]
        [Required(ErrorMessage = "This field is required!")]
        public string Username { get; set; }

        [DisplayName("Password:")]
        [Required(ErrorMessage = "This field is required!")]

        public string Password { get; set; }
        [DisplayName("First Name:")]
        [Required(ErrorMessage = "This field is required!")]

        public string FirstName { get; set; }

        [DisplayName("Last Name :")]
        [Required(ErrorMessage = "This field is required!")]

        public string LastName { get; set; }
    }
}