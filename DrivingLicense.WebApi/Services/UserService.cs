using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using DrivingLicense.WebApi.Models;
using DrivingLicense.WebApi.Services.Interfaces;

namespace DrivingLicense.WebApi.Services
{
    public class UserService : IUserService
    {
        private UserManager<ApplicationUser> _userManager = null;
        private SignInManager<ApplicationUser> _signInManager = null;
        private IConfiguration _config = null;

        public UserService(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
        }


        public async Task<IdentityResult> RegisterUserAsync(string userName, string email, string password)
        {
            var appUser = new ApplicationUser()
            {
                UserName = userName,
                Email = email
            };

            var result = await _userManager.CreateAsync(appUser, password);

            return result;
        }

        public async Task<string> LoginAsync(string email, string password)
        {
            ApplicationUser user = new ApplicationUser();
            user.Email = email;

            bool isAuthorized = false;

            var appUser = await AuthenticateUserAsync(user, password);
            user = appUser;

            isAuthorized = !(appUser == null);

            if(isAuthorized != false)
            {
                var tokenStr = GenerateJsonWebToken(user);
                return tokenStr;
            }

            return String.Empty;
        }

        private string GenerateJsonWebToken(ApplicationUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["TokenAuthentication:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };


            var token = new JwtSecurityToken(
                    issuer: _config["TokenAuthentication:Issuer"],
                    audience: _config["TokenAuthentication:Audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials
                );


            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedToken;
        }

        private async Task<ApplicationUser> AuthenticateUserAsync(ApplicationUser applicationUser, string password)
        {
            var user = await _userManager.FindByEmailAsync(applicationUser.Email);
            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            if (result.Succeeded)
            {
                return user;
            }else {

                return null;
            }
        }
    }
}
