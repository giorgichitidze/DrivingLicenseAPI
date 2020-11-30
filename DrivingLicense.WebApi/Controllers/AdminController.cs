using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrivingLicense.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrivingLicense.WebApi.Controllers
{
    public class AdminController : Controller
    {

        ctor 

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetTicket(LicenseCategory licenseCategory)
        {
            return null;
        }
    }
}
