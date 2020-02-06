using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockTracker.Models.ViewModels
{
    public class AccountsRegisterVM
    {

        [Required(ErrorMessage = "Please enter a username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail address")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please re-enter a password")]
        [Display(Name = "Password validation")]
        public string ConfirmPassword { get; set; }

    }
}
