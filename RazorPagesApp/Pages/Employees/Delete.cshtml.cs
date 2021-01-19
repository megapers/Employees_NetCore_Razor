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
    public class DeleteModel : PageModel
    {
        private IEmployeeRepository _employeeRepository;

        public DeleteModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [BindProperty]
        public Employee Employee { get; set; }
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);

            if(Employee is null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Employee deletedEmployee = _employeeRepository.Delete(Employee.Id);

            if (deletedEmployee is null)
            {
                return RedirectToPage("/NotFound");
            }

            return RedirectToPage("/Index");
        }
    }
}
