using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IGeneral
{
    internal class AppStart : IAppStart, ITime
    {
        private static DateTime appStart = new DateTime();

        public AppStart(string appName = "Default for namespace Fundamentals / Classes / IGeneral, appName string input",
            string correlationID = "Default for namespace Fundamentals / Classes / IGeneral, correlationID input")
        {
            appStart = DateTime.UtcNow;
        }
    }
}
