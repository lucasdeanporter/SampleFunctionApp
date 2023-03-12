using SampleFunctionApp.Classes.IAppSessionContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Classes.ITime
{
    internal class Time : ITime
    {

        public readonly DateTime Start { get; set; }
        public readonly DateTime End { get; set; }
        private Time()
        {
            Start = DateTime.UtcNow;
        }

        bool End()
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
