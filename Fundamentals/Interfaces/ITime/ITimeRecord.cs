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
        public static DateTime EndTime { get => DateTime.UtcNow; }
        public static DateTime StartTime { get => ITimeArchive.start; set => ITimeArchive.start = value; }
        public static DateTime GetTimeNow => DateTime.UtcNow;
        static void OnStart(); // set time
        public void OnEnd(); // set end
    }
}
