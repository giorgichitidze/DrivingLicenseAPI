using DrivingLicense.WebApi.Models.BaseTypes;
using DrivingLicense.WebApi.Models.Interfaces;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class Answer : BaseEntity, IAnswer
    {
        [JsonProperty("Ans")]
        public string Ans { get; set; }

        [JsonProperty("Correct")]
        public bool IsCorrect { get; set; }
    }
}