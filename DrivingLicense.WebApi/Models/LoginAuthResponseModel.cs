using System;
using DrivingLicense.WebApi.Models.BaseTypes;

namespace DrivingLicense.WebApi.Models
{
    public class LoginAuthResponseModel : ResponseModel
    {
        public string Token { get; set; }
    }
}
