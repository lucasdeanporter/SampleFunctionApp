using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    internal interface ITimeRecord : ITimeArchive
    {
        public static DateTime EndTime;
        public static DateTime StartTime;
        public static DateTime GetTimeNow => DateTime.UtcNow;
    }
}
