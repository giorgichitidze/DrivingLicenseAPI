using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
   public partial class Ticket : BaseEntity
    {
        [JsonProperty("Answers")]
        public Answer[] Answers { get; set; }

        [JsonProperty("Help")]
        public string Help { get; set; }

        [JsonProperty("Image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        [JsonProperty("Question")]
        public string Question { get; set; }
    }
}