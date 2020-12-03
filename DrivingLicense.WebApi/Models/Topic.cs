using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class Topic : BaseEntity
    { 
        public string Name { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public LicenseCategory Category { get; set; }

    }
}