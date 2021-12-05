using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public ViewResult Index()
        {
            //return Json(new { id = 1, name = "Jyotirmoy" }); ;
            //return _employeeRepository.GetEmployee(1).Name;
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public ViewResult Test()
        {
           
            ViewData["code"] = "from codeeee";
            return View();
        }

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            //return View(model);
            //return View("Test");
            //return View("MyViews/Test.cshtml");

            //ViewData["Employee"] = model;
            //ViewData["PageTitle"] = "Employee Details";
            //return View();

            //ViewBag.Employee = model;
            //ViewBag.PageTitle = "Employee Details";
            //return View();

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            };

            //ViewBag.PageTitle = "Employee Details";
            //return View(model);

            return View(homeDetailsViewModel);
        }

    }
}
