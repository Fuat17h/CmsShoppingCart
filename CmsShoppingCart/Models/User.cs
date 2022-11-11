using System.ComponentModel.DataAnnotations;

namespace CmsShoppingCart.Models
{
    public class User
    {
        [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        [Display(Name = "Username")]
        public string UserName { get; set; }


        [Required, EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string Password { get; set; }

        //public User() { }

        //public User(AppUser appUser)
        //{
        //    UserName = appUser.UserName;
        //    Email = appUser.Email;
        //    Password = appUser.PasswordHash;
        //}

    }
}


//Passwords must be at least 6 characters.
//Passwords must have at least one non alphanumeric character.
//Passwords must have at least one digit ('0'-'9').
//Passwords must have at least one uppercase ('A'-'Z').
