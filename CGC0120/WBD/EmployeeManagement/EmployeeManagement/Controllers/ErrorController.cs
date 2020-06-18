using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{StatusCode}")]
        public ViewResult Index(int StatusCode)
        {
            ViewBag.ErrorMessage = $"Error {StatusCode}: Sorry the resource you requested could not be found";
            return View("PageNotFound");
        }

        [Route("Error")]
        public ViewResult Exception()
        {
            return View("Error");
        }
    }
}
