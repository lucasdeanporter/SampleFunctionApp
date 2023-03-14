using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    public interface ITimeArchive
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        static DateTime internalCorrelationID { get; set; } // TODO: Retrieve from application. After it tests connections with... TODO: Explore DateTime limitations as a GUID.
        // internalCorrelationID
        // externalCorrelationID comes from Application Network side.
        // subject Name
    }
}
