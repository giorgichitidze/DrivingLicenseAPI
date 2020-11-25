using DrivingLicense.WebApi.Models.Interfaces;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class LicenseCategory : ILicenseCategory
    {
        [JsonProperty("Img")]
        public string Img { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Topics")]
        public ITopic[] Topics { get; set; }
    }
}