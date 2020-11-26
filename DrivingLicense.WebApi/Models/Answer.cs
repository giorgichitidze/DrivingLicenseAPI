using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class Answer : BaseEntity
    {
        [JsonProperty("Ans")]
        public string Ans { get; set; }

        [JsonProperty("Correct")]
        public bool IsCorrect { get; set; }
    }
}