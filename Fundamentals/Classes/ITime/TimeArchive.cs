using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;

namespace SampleFunctionApp.Fundamentals.Classes.ITime
{
    public class TimeArchive : ITimeArchive
    {
        public TimeArchive() 
        {
            Start = null;
        }
        public DateTime End { get; set; }
        public DateTime relateId { get; set; }
        public DateTime? Start { get; set; }
    }
}
