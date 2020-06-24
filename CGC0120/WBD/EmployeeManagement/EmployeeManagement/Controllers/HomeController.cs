using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Authorize]
    //[Route("{controller}")]
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeController(IEmployeeRepository _employeeRepository,
                              IWebHostEnvironment _webHostEnvironment)
        {
            employeeRepository = _employeeRepository;
            webHostEnvironment = _webHostEnvironment;
        }

        [AllowAnonymous]
        //[Route("~/")]
        //[Route("Home")]
        //[Route("Home/Index")]
        public ViewResult Index()
        {
            return View(employeeRepository.GetAllEmployee());
        }

        //[Route("Home/Detail")]
        //[Route("Home/Details/{id?}")]
        public ViewResult Details(int? id)
        {
            try
            {
                var employee = employeeRepository.GetEmployee(id.Value);
                if (employee == null)
                {
                    ViewBag.Id = id.Value;
                    return View("NotFound");
                }
                var homeDetailsViewModel = new HomeDetailsViewModel()
                {
                    Employee = employee,
                    Title = "Employee Details"
                };
                return View(homeDetailsViewModel);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        public ViewResult Create()
        {
            //ViewBag.Departments = departmentRepository.Gets();
            return View();
        }

        [HttpPost]
        //public RedirectToActionResult Create(Employee employee)
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadAvatar(model);

                //Multiple upload
                //if (model.Photos != null && model.Photos.Count > 0)
                //{
                //    foreach(IFormFile photo in model.Photos)
                //    {
                //        string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                //        uniqueFileName = $"{Guid.NewGuid().ToString()}_{photo.FileName}";
                //        var filePath = Path.Combine(uploadFolder, uniqueFileName);
                //        photo.CopyTo(new FileStream(filePath, FileMode.Create));
                //    }
                //}
                Employee newEmp = new Employee()
                {
                    AvatarPath = uniqueFileName ?? $"nonavatar.png",
                    Department = model.Department,
                    Email = model.Email,
                    Name = model.Name,
                    PhoneNumber = null
                };
                employeeRepository.Add(newEmp);
                return RedirectToAction("details", new { id = newEmp.Id });
            }
            return View();
        }

        private string UploadAvatar(HomeCreateViewModel model)
        {
            var uniqueFileName = string.Empty;
            //Single upload
            if (model.Photo != null)
            {
                string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = $"{Guid.NewGuid()}_{model.Photo.FileName}";
                var filePath = Path.Combine(uploadFolder, uniqueFileName);
                using (var fileName = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileName);
                }
            }

            return uniqueFileName;
        }

        [HttpGet]
        public ViewResult Edit(int? id)
        {
            var employee = employeeRepository.GetEmployee(id ?? 1);
            var editEmp = new HomeEditViewModel()
            {
                ExistingAvatarPath = employee.AvatarPath,
                Department = employee.Department,
                Email = employee.Email,
                Id = employee.Id,
                Name = employee.Name,
            };
            return View(editEmp);
        }

        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = employeeRepository.GetEmployee(model.Id);
                employee.Name = model.Name;
                employee.Department = model.Department;
                employee.Email = model.Email;
                employee.AvatarPath = UploadAvatar(model);
                if(model.ExistingAvatarPath != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "images", model.ExistingAvatarPath);
                    System.IO.File.Delete(filePath);
                }
                employeeRepository.Edit(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                if (employeeRepository.Delete(id))
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ViewResult Details2()
        {

            var employee = employeeRepository.GetEmployee(1);
            ViewData["EmployeeTitle"] = "Employee Details";
            ViewData["Employee"] = employee;
            return View();
        }

        public ViewResult About()
        {
            var employee = employeeRepository.GetEmployee(1);
            ViewBag.EmployeeTitle = "Employee Title";
            ViewBag.Employee = employee;
            return View();
        }

        public ViewResult SiteMap()
        {
            var employee = employeeRepository.GetEmployee(1);
            ViewBag.EmployeeTitle = "Employee Title";
            return View(employee);
        }
    }
}
