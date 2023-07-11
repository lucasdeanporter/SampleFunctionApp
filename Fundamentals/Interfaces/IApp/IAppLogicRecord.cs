using SampleFunctionApp.Fundamentals.Classes.IApp;
using SampleFunctionApp.Fundamentals.Classes.ITime;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppLogicRecord : ILogicRecord
    {
        public AppRecord appRecord { get; set; }
        public TimeRecord timeRecord { get; set; }
    }
}
