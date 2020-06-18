using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee()
                { 
                    Id = 1, 
                    Name = "Trung Nguyễn", 
                    Department = Dept.IT, 
                    Email = "trung.nguyen@codegym.vn", 
                    AvatarPath = "images/nonavatar.png" 
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Quang Nguyễn",
                    Department = Dept.HR,
                    Email = "quang.nguyen@codegym.vn",
                    AvatarPath = "images/nonavatar.png"
                }
            };
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Create(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
            return employee;
        }
    }
}
