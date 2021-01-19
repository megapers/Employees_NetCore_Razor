using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorPagesTutorial.Model
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MinLength(3, ErrorMessage = "Name should contain at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage="Invalid Email")]
        [Display(Name="Office Email")]
        public string  Email { get; set; }
        public string Photopath { get; set; }
        [Required]
        public Dept? Department { get; set; }
    }
}
