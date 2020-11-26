using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class Topic : BaseEntity
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Tickets")]
        public Ticket[] Tickets { get; set; }
    }
}