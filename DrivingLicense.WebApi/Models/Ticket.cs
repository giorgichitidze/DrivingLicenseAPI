using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
   public partial class Ticket : BaseEntity
   { 
        public string Question { get; set; }
        public string Image { get; set; }
        public string Help { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public int TopicId { get; set; }
        [JsonIgnore]
        public Topic Topic { get; set; }
    }
}