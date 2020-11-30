using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrivingLicense.WebApi.Models;
using DrivingLicense.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrivingLicense.WebApi.Controllers
{
    public class AdminController : Controller
    {
        private IClientService _clientService;

        public AdminController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetTicket([FromBody] LicenseCategory licenseCategory)
        {
            return null;
        }
    }
}
