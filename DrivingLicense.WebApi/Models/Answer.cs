using DrivingLicense.WebApi.Models.Interfaces;

namespace DrivingLicense.WebApi.Models
{
    public class Answer : IAnswer
    {
        public int Answer {get;set;}
        public string Ans {get;set;}
        public bool IsCorrect { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}