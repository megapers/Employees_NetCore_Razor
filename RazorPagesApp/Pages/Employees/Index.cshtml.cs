using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Model;
using RazorPagesTutorial.Services;

namespace RazorPagesApp.Pages.Shared.Employees
{
    public class IndexModel : PageModel
    {
        private IEmployeeRepository _employeeRepository; 
        public IEnumerable<Employee> Employees { get; set;}

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void OnGet()
        {
            Employees = _employeeRepository.Search(SearchTerm);
        }
    }
}
