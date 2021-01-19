using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Model;
using RazorPagesTutorial.Services;

namespace RazorPagesApp.Pages.Employees
{
    public class EditModel : PageModel
    {
        private IEmployeeRepository _employeeRepository;
        IWebHostEnvironment _iWebHostEnvironment;//Getting absoulute physical path to wwwroot folder
        public EditModel(IEmployeeRepository employeeRepository, IWebHostEnvironment iWebHostEnvironment)
        {
            _employeeRepository = employeeRepository;
            _iWebHostEnvironment = iWebHostEnvironment;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }

        [BindProperty]
        public bool Notify { get; set; }

        public string Message { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Employee =_employeeRepository.GetEmployee(id.Value);
            }
            else
            {
                Employee = new Employee();
            }
            if(Employee is null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if(Photo != null)
                {
                    string filePath = Path.Combine(_iWebHostEnvironment.WebRootPath, "images", Employee.Photopath);
                    System.IO.File.Delete(filePath);
                    Employee.Photopath = ProcessUploadedFile();
                }
                if(Employee.Id > 0)
                {
                    Employee = _employeeRepository.Update(Employee);
                }
                else
                {
                    Employee = _employeeRepository.Add(Employee);
                }
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPostUpdateNotificationPreferences(int id)
        {
            if (Notify)
            {
                Message = "Thank you for turning on notification";
            }
            else
            {
                Message = "You have turned off email notifications";
            }

            TempData["message"] = Message;

            return RedirectToPage("Details", new {id = id});
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;

            if(Photo != null)
            {
                string uploadsFolder = Path.Combine(_iWebHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        
    }
}
