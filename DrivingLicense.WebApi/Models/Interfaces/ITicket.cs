using System;
namespace DrivingLicense.WebApi.Models.Interfaces
{
    public interface ITicket
    {
        IAnswer[] Answers { get; set; }
        string Help { get; set; }
        string Image { get; set; }
        string Question { get; set; }
    }
}
