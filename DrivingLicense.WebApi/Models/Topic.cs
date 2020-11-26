using DrivingLicense.WebApi.Models.Interfaces;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
   public partial class Topic : BaseEntity, ITopic
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Tickets")]
        public ITicket[] Tickets { get; set; }
    }
}