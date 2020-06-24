using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employee Create(Employee employee)
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

        public Employee Get(int id)
        {
            return context.Employees.Find(id);
        }

        public IEnumerable<Employee> Gets()
        {
            return context.Employees;
        }

        public Employee Update(Employee employee)
        {
            var editEmp = context.Employees.Attach(employee);
            editEmp.State = EntityState.Modified;
            context.SaveChanges();
            return employee;
        }
    }
}
