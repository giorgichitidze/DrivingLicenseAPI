using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Services.Interfaces
{
    public interface IClientService
    {
         void AddTicketAsync(LicenseCategory licenseCategory);
    }
}