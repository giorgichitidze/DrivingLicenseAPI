using System;
namespace DrivingLicense.WebApi.Models.Interfaces
{
    public interface ITopic
    {
        string Name { get; set; }
        ITicket[] Tickets { get; set; }
    }
}
