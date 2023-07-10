using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimeArchive : IArchive
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        static DateTime internalCorrelationID { get; set; } // Use timestamp as unique correlationID
    }
}
