using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DrivingLicense.WebApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(string userName, string email, string password);
        Task<string> LoginAsync(string email, string password);
    }
}
