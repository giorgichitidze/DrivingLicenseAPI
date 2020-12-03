using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class Answer : BaseEntity
    { 
        public string Ans { get; set; }
        public bool Correct { get; set; }
        public int TicketId { get; set; }
        [JsonIgnore]
        public Ticket Ticket { get; set; }
    }
}