using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Services.Interfaces
{
    public interface IClientService
    {
         void AddTicket(LicenseCategory licenseCategory);
    }
}