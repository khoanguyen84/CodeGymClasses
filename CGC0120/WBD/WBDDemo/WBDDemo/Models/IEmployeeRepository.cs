using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
        Employee Get(int id);
        Employee Create(Employee employee);
        Employee Update(Employee employee);
        bool Delete(int id);
    }
}
