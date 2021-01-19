using Microsoft.AspNetCore.Mvc;
using RazorPagesTutorial.Model;
using RazorPagesTutorial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesApp.Pages.ViewComponents
{
    public class HeadCountViewComponent: ViewComponent
    {
        private IEmployeeRepository _employeeRepository;
        public HeadCountViewComponent(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IViewComponentResult Invoke(Dept? dept = null)
        {
            var result = _employeeRepository.EmployeeCountByDepartment(dept);
            return View(result);
        }
    }
}
