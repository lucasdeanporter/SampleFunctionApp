using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    internal interface ITimeRecord : IRecord
    {
        public static DateTime StartTime;
        public static DateTime EndTime;
        public static DateTime GetTimeNow => DateTime.UtcNow
        ITimeArchive timeArchive {get; set;}
    }
}
