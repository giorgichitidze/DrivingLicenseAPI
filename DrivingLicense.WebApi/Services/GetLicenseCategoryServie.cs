using System;
using System.Collections.Generic;
using System.Linq;
using DrivingLicense.WebApi.Infastructure.Interfaces;
using DrivingLicense.WebApi.Models;

namespace DrivingLicense.WebApi.Services.Interfaces
{
    public class GetLicenseCategoryService : IGetLicenseCategory
    {
        private IRepository<LicenseCategory> _repository;

        public GetLicenseCategoryService(IRepository<LicenseCategory> repository)
        {
            _repository = repository;
        }

        public List<LicenseCategory> GetLicenseCategories()
        {
            var collection = _repository.GetAll();

            return collection.ToList();
        }
    }
}
