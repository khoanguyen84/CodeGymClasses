using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private AppDBContext context;
        public SqlEmployeeRepository(AppDBContext context)
        {
            this.context = context;
        }
        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public bool Delete(int id)
        {
            var delEmp = context.Employees.Find(id);
            context.Employees.Remove(delEmp);
            return context.SaveChanges() > 0;
        }

        public bool Edit(Employee employee)
        {
            employee.AvatarPath = employee.AvatarPath ?? @"~/images/nonavatar.png";
            var editEmp = context.Employees.Attach(employee);
            editEmp.State = EntityState.Modified;
            return  context.SaveChanges() > 0;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employees.Find(id);
        }
    }
}
