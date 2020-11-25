using System;
namespace DrivingLicense.WebApi.Models.Interfaces
{
    public interface IAnswer
    {
        string Ans { get; set; }
        bool IsCorrect { get; set; }
    }
}
