using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>
            {
                new Employee(){ Department = Dept.IT, Email = "khoa.nguyen@codegym.vn", Id = 1, Name = "Khoa", AvatarPath="~/images/nonavatar.png"},
                new Employee(){ Department = Dept.HR, Email = "khoa.nguyen@codegym.vn", Id = 2, Name = "Phuc", AvatarPath="~/images/nonavatar.png"},
                new Employee(){ Department = Dept.IT, Email = "khoa.nguyen@codegym.vn", Id = 3, Name = "Khanh", AvatarPath="~/images/nonavatar.png"},
                new Employee(){ Department = Dept.IT, Email = "hoang.phan@codegym.vn", Id = 4, Name = "Hoang", AvatarPath="~/images/nonavatar.png"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employee.AvatarPath = @$"~/images/nonavatar.png";
            employees.Add(employee);
            return employee;
        }

        public bool Delete(int id)
        {
            try
            {
                var delEmp = GetEmployee(id);
                if(delEmp != null)
                {
                    employees.Remove(delEmp);
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool Edit(Employee employee)
        {
            try
            {
                var oldEmp = GetEmployee(employee.Id);
                oldEmp.Email = employee.Email;
                oldEmp.Department = employee.Department;
                oldEmp.Name = employee.Name;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
