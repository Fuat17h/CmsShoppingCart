﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CmsShoppingCart.Models
{
    public class UserEdit
    {
       
        [Required, EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password), MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string Password { get; set; }

        public UserEdit() { }

        public UserEdit(AppUser appUser)
        {
            Email = appUser.Email;
            Password = appUser.PasswordHash;
        }
    }
}
