using System.ComponentModel;
using DrivingLicense.WebApi.Models;
using DrivingLicense.WebApi.Services.Interfaces;
using DrivingLicense.WebApi.Infastructure.Interfaces;
using System.Threading.Tasks;

namespace DrivingLicense.WebApi.Services
{
    public class ClientService : IClientService
    {
        IRepository<LicenseCategory> _repository;

        public ClientService(IRepository<LicenseCategory> repository)
        {
            _repository = repository;
        }

        public async Task AddTicketAsync(LicenseCategory licenseCategory)
        {
            {
                if (licenseCategory != null)
                {
                    await _repository.Insert(licenseCategory);
                }
            }
        }
    }
}
