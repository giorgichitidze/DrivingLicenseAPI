using System;
using System.Collections.Generic;
using System.Linq;
using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Services.Interfaces
{
    public interface IGetLicenseCategory
    {
        List<LicenseCategory> GetLicenseCategories();
    }
}
