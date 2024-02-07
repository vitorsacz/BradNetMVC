using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController1 : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Games" });
            departments.Add(new Department { Id = 2, Name = "Consoles" });
            return View(departments);        }
    }
}
