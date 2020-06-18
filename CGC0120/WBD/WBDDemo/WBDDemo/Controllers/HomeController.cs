using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBDDemo.Models;
using WBDDemo.ViewModels;

namespace WBDDemo.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            var employees = employeeRepository.Gets();
            return View(employees);
        }
        public ViewResult Details(int? id)
        {
            var detailViewModel = new HomeDetailViewModel()
            {
                Employee = employeeRepository.Get(id ?? 1),
                TitleName = "Employee Detail"
            };
            return View(detailViewModel);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Employee model)
        {
            var newEmp = employeeRepository.Create(model);
            return RedirectToAction("Details", new { id = newEmp.Id });
        }
    }
}
