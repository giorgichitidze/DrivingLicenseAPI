using System;
using Microsoft.AspNetCore.Identity;

namespace DrivingLicense.WebApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; } 
    }
}
