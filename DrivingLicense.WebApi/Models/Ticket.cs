using DrivingLicense.WebApi.Models.BaseTypes;
using DrivingLicense.WebApi.Models.Interfaces;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
   public partial class Ticket : BaseEntity, ITicket
    {
        [JsonProperty("Answers")]
        public IAnswer[] Answers { get; set; }

        [JsonProperty("Help")]
        public string Help { get; set; }

        [JsonProperty("Image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        [JsonProperty("Question")]
        public string Question { get; set; }
    }
}