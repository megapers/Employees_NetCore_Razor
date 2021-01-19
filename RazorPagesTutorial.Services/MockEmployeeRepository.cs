using RazorPagesTutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorPagesTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@mail.com", Photopath = "mary.png" },
                new Employee(){Id = 2, Name = "John", Department = Dept.IT, Email = "john@mail.com", Photopath = "john.png" },
                new Employee(){Id = 3, Name = "Sarah", Department = Dept.IT, Email = "sarah.com", Photopath = "sarah.png" },
                new Employee(){Id = 4, Name = "David", Department = Dept.Payroll, Email = "david.com" },
            };
        }

        public Employee Add(Employee addedEmployee)
        {
            addedEmployee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(addedEmployee);
            return addedEmployee;
        }

        public Employee Delete(int id)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<DptHeadCount> EmployeeCountByDepartment(Dept? dept)
        {
            IEnumerable<Employee> query = _employeeList;
            if (dept.HasValue)
            {
                query = query.Where(e => e.Department == dept.Value);
            }

            return query.GroupBy(e => e.Department)
                 .Select(g => new DptHeadCount() 
                 {
                     Department = g.Key.Value,
                     Count = g.Count()
                 }).ToList();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;            
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return _employeeList;
            }
            return _employeeList.Where(e => e.Name.Contains(searchTerm) ||
                                            e.Email.Contains(searchTerm));
        }

        public Employee Update(Employee updatedEmployee)
        {
            var currentEmployee = _employeeList.FirstOrDefault(e => e.Id == updatedEmployee.Id);
            if(currentEmployee != null)
            {
                currentEmployee.Name = updatedEmployee.Name;
                currentEmployee.Email = updatedEmployee.Email;
                currentEmployee.Department = updatedEmployee.Department;
                currentEmployee.Photopath = updatedEmployee.Photopath;
            }
            return currentEmployee;
        }
    }
}
