using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using HPlus.Ecommerce.Validation;

namespace HPlus.Ecommerce.Models
{
    public class Login
    {
        [Required]
        [EmailAddress(ErrorMessage = "Usernames must be valid email address")]
        public string Username { get; set; }
        [Required]
        [CommonPasswords(ErrorMessage = "This password is too common")]
        [MinLength(8, ErrorMessage = "This password is too short. Need minimum 8 characters")]
        public string Password { get; set; }
    }
}