using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Can not exceed 20 characters")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
            ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string AvatarPath { get; set; }
    }
}
