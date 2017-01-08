using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(EmployeeModel employeeModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("Result");
        }

        public string Result()
        {
            return "Success";
        }
    }
}
