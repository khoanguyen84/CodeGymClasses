using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private List<Department> departments;
        public DepartmentRepository()
        {
            departments = new List<Department>()
            {
                new Department(){ Id = 0, Name = "None" },
                new Department(){ Id = 1, Name = "IT" },
                new Department(){ Id = 2, Name = "HR" },
                new Department(){ Id = 3, Name = "Payroll" },
            };
        }
        public IEnumerable<Department> Gets()
        {
            return departments;
        }
    }
}
