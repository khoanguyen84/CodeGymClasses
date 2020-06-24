using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
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
            );
        }
    }
}
