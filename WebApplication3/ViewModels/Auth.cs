using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.ViewModels
{
    public class AuthLogin
    {
        [MinLength(2)]
        [Required(ErrorMessage = "Please Input Username !")]
        public string Username { get; set; }

   
        [MinLength(5)]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}