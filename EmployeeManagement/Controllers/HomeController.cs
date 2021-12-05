using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        //[Route("~/home")]
        //[Route("Index")]
        //[Route("[action]")]
        //[Route("~/")]
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

        //[Route("{id?}")]
        public ViewResult Details(int? id)
        {
            //Employee model = _employeeRepository.GetEmployee(id);
            //return View(model);
            //return View("Test");
            //return View("MyViews/Test.cshtml");

            //ViewData["Employee"] = model;
            //ViewData["PageTitle"] = "Employee Details";
            //return View();

            //ViewBag.Employee = model;
            //ViewBag.PageTitle = "Employee Details";
            //return View();

            if (id == 0)
                id = 1;
            

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {

                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };

            //ViewBag.PageTitle = "Employee Details";
            //return View(model);

            return View(homeDetailsViewModel);
        }

    }
}
