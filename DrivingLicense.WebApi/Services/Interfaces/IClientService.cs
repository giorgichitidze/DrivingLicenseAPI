using System.Threading.Tasks;
using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Services.Interfaces
{
    public interface IClientService
    {
         Task AddTicketAsync(LicenseCategory licenseCategory);
    }
}
