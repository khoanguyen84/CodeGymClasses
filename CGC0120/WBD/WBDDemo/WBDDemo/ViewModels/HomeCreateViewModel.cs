using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WBDDemo.Models;

namespace WBDDemo.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Can not exceed 20 characters")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Photo { get; set; }
    }
}
