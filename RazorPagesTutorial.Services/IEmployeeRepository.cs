using RazorPagesTutorial.Model;
using System;
using System.Collections.Generic;

namespace RazorPagesTutorial.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Search(string searchTerm);

        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Update(Employee updatedEmployee);
        Employee Add(Employee addedEmployee);
        Employee Delete(int id);
        IEnumerable<DptHeadCount> EmployeeCountByDepartment(Dept? dept);

    }
}
