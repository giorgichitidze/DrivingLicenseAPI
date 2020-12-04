using System;
using System.Collections.Generic;
using System.Linq;
using DrivingLicense.WebApi.Infastructure.Interfaces;
using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Services.Interfaces
{
    public class GetLicenseCategoryService : IGetLicenseCategory
    {

        public GetLicenseCategoryService(IRepository<LicenseCategory> repository)
        {
        }

        public List<LicenseCategory> GetLicenseCategories()
        {
        }
    }
}
