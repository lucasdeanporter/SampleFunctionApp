using Microsoft.Extensions.Logging.Abstractions;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.ITime
{
    public class TimeArchive : ITimeArchive
    {
        public TimeArchive() 
        {
            Start = null;
        }
        public DateTime End { get; set; }
        public string RelateId { get; set; }
        public DateTime relateId { get; set; }
        public DateTime? Start { get; set; }
    }
}
