using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrivingLicense.WebApi.Infastructure.Interfaces;
using DrivingLicense.WebApi.Models;
using System.Threading.Tasks;
using DrivingLicense.WebApi.Services.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Quizz.WebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("registeruser")]
        public async Task<IActionResult> Register(string userName, string email, string password)
        {
           var result = await _userService.RegisterUserAsync(userName, email, password);

           if(result.Succeeded == true)
            {
                return Ok(new { IsSuccesfull = true, message = "You have registered succesfully, you can log in now with your credentials" });
            }else {
                return Ok(new { IsSuccessfull = false, message = result.Errors.ToList()[0].Description});
            }
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var result = await _userService.LoginAsync(email, password);

            if(!string.IsNullOrEmpty(result))
            {
                return Ok(new LoginAuthResponseModel { IsError = false, Message = "Successfully loged in", Token = result });
            }else{
                return Ok(new LoginAuthResponseModel { IsError = true, Message = "Logged in was unsuccesfull", Token = result });
            }
        }

        [HttpGet]
        public void Get()
        {
            Console.WriteLine("ASDA");
        }
    }
}
