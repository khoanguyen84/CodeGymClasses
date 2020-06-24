using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;

namespace WebMVC.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    AvatarPath = "",
                    Department = Dept.IT,
                    Email = "khoa.nguyen@codegym.vn",
                    Id = 1,
                    Name = "Khoa"
                },
                new Employee()
                {
                    AvatarPath = "",
                    Department = Dept.HR,
                    Email = "phap.phan@codegym.vn",
                    Id = 2,
                    Name = "Pháp"
                }
            );
        }
    }
}
