using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.ITime
{
    internal class TimeArchive : ITimeArchive
    {
        public TimeArchive() 
        {
            Start = ITimeRecord.GetTimeNow;
            RelateId = this.Start.ToString();
        }
        public DateTime? Start = null;
        public DateTime End { get; set; }
        public string RelateId { get; set; }
    }
}
