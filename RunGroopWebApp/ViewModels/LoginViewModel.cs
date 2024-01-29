﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace RunGroopWebApp.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name="Email Address")]
        [Required(ErrorMessage="Email Adress is required")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
