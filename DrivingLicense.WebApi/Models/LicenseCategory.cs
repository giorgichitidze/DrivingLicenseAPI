using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrivingLicense.WebApi.Models.BaseTypes;
using Newtonsoft.Json;

namespace DrivingLicense.WebApi.Models
{
    public partial class LicenseCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Img { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}