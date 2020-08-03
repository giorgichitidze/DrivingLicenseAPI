using System;
namespace DrivingLicense.WebApi.Models.BaseTypes
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
