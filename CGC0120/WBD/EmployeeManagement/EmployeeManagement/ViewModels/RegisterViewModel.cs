using EmployeeManagement.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(controller:"account", action: "IsEmailInUse")]
        [CustomValidationEmail(domainName:"codegym.vn", ErrorMessage ="Emails must has domain codegym.vn")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password not match")]
        public string ConfirmPassword { get; set; }
        public string City { get; set; }
    }
}
