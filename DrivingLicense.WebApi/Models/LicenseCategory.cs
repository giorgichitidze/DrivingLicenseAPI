using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class LicenseCategory : BaseEntity
    {
        [JsonProperty("Img")]
        public string Img { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Topics")]
        public Topic[] Topics { get; set; }
    }
}