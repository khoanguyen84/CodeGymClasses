using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{StatusCode}")]
        public ViewResult Index(int StatusCode)
        {
            ViewBag.ErrorMessage = $"Error {StatusCode}: The resource you requested can not be found.";
            return View();
        }

        [Route("Error")]
        public ViewResult Error()
        {
            return View();
        }
    }
}
