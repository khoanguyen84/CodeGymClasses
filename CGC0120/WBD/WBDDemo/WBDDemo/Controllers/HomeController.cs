using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WBDDemo.Models;
using WBDDemo.ViewModels;

namespace WBDDemo.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(IEmployeeRepository employeeRepository,
                               IWebHostEnvironment webHostEnvironment)
        {
            this.employeeRepository = employeeRepository;
            this.webHostEnvironment = webHostEnvironment;
        }
        public ViewResult Index()
        {
            var employees = employeeRepository.Gets();
            return View(employees);
        }
        public ViewResult Details(int? id)
        {
            try
            {
                var employee = employeeRepository.Get(id.Value);
                if (employee == null)
                {
                    return View("~/Views/Error/EmployeeNotFound.cshtml", id.Value);
                }
                var detailViewModel = new HomeDetailViewModel()
                {
                    Employee = employee,
                    TitleName = "Employee Detail"
                };
                return View(detailViewModel);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Department = model.Department,
                    Email = model.Email,
                    Name = model.Name
                };
                var uniqueFileName = string.Empty;
                if (model.Photo != null)
                {
                    var folderPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    uniqueFileName = $"{Guid.NewGuid()}_{model.Photo.FileName}";
                    //uniqueFileName = model.Photo.FileName;
                    var filePath = Path.Combine(folderPath, uniqueFileName);
                    using (var fileName = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo.CopyTo(fileName);
                    }
                }
                employee.AvatarPath = uniqueFileName;
                var newEmp = employeeRepository.Create(employee);
                return RedirectToAction("Details", new { id = newEmp.Id });
            }
            return View();
        }

        public ViewResult Edit(int id)
        {
            var employee = employeeRepository.Get(id);
            
            if (employee == null)
            {
                return View("~/Views/Error/EmployeeNotFound.cshtml", id);
            }
            var editViewModel = new HomeEditViewModel()
            {
                AvatarPath = employee.AvatarPath,
                Department = employee.Department,
                Email = employee.Email,
                Id = employee.Id,
                Name = employee.Name
            };
            return View(editViewModel);
        }

        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Email = model.Email,
                    Department = model.Department,
                    Id = model.Id,
                    Name = model.Name,
                    AvatarPath = model.AvatarPath
                };
                if (model.Photo != null)
                {
                    var folderPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    var uniqueFileName = $"{Guid.NewGuid()}_{model.Photo.FileName}";
                    var filePath = Path.Combine(folderPath, uniqueFileName);
                    using (var fileName = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo.CopyTo(fileName);
                    }
                    employee.AvatarPath =uniqueFileName;
                    if (!string.IsNullOrEmpty(model.AvatarPath))
                    {
                        string delFilePath = Path.Combine(webHostEnvironment.WebRootPath, "images", model.AvatarPath);
                        System.IO.File.Delete(delFilePath);
                    }
                }
                var editEmp = employeeRepository.Update(employee);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            if (employeeRepository.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
