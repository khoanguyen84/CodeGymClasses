using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name can not exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        //public List<IFormFile> Photos { get; set; }
        public IFormFile Photo { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
