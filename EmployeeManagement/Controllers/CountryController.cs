using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class CountryController : Controller
    {
        private ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public string Index()
        {
            return _countryRepository.GetCountry(1).CountryName;
            //return "index";
        }
        public JsonResult Details()
        {
            Country model = new Country();
            model = _countryRepository.GetCountry(2);
            return Json(model);
        }
    }
}
