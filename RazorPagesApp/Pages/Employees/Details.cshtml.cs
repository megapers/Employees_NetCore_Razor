using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Model;
using RazorPagesTutorial.Services;

namespace RazorPagesApp.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private IEmployeeRepository _employeeRepository;
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Employee Employee { get; set; }
        
        [TempData]
        public string Message { get; set; }
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);

            if(Employee is null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
