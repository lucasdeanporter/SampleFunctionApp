using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimeRecord : IRecord
    {
        public ITimeArchive timeArchive { get; set; }
        public TimeSpan Duration { get; set; }
        public bool HasEnd { get; set; }
        public bool HasStart();
        int GetDuration(string secondMinuteHourOrDay);
        bool EndTimeExists();
    }
}
