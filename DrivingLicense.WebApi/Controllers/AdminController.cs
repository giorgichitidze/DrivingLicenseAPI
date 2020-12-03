using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrivingLicense.WebApi.Models;
using DrivingLicense.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrivingLicense.WebApi.Controllers
{
    [ApiController]
    [Route("Admin")]
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

        [HttpPost]
        [Route("testpost")]
        public IActionResult TestMethod()
        {
            Console.WriteLine("test");

            return Ok(new {Message = "Ok", isError = false});
        }

        [HttpPost]
        [Route("setticket")]
        public async Task<IActionResult> SetTicket([FromBody] List<LicenseCategory> licenseCategory)
        {

            await Task.Run(() => {
                foreach(var item in licenseCategory)
                {
                    _clientService.AddTicketAsync(item);
                }
            });


            return Ok(new {
                    IsSuccesfull = true,
                    message = "Its ok"
                });

        }
    }

    public class Person
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }
    }
}
