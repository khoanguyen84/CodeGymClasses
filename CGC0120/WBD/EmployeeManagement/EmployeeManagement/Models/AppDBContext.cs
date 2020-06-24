using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class AppDBContext : IdentityDbContext<ApplicationUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Department = Dept.IT, Email = "khoa.nguyen@codegym.vn", Id = 1, Name = "Khoa", AvatarPath = "~/images/nonavatar.png" },
                new Employee() { Department = Dept.HR, Email = "khoa.nguyen@codegym.vn", Id = 2, Name = "Phuc", AvatarPath = "~/images/nonavatar.png" },
                new Employee() { Department = Dept.IT, Email = "khoa.nguyen@codegym.vn", Id = 3, Name = "Khanh", AvatarPath = "~/images/nonavatar.png" },
                new Employee() { Department = Dept.IT, Email = "hoang.phan@codegym.vn", Id = 4, Name = "Hoang", AvatarPath = "~/images/nonavatar.png" }
                );
        }
    }
}
