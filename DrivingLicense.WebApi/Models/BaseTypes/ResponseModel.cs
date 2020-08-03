using System;
namespace DrivingLicense.WebApi.Models.BaseTypes
{
    public abstract class ResponseModel
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
    }
}
