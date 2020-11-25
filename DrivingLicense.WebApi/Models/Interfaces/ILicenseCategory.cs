using System;
namespace DrivingLicense.WebApi.Models.Interfaces
{
    public interface ILicenseCategory
    {
        string Img { get; set; }

        string Name { get; set; }

        ITopic[] Topics { get; set; }
        
    }
}
