using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppRecord : IAppRecord
    {
        public AppArchive appArchive { get; set; }

        public bool HandleWriteFailure(dynamic toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(dynamic wasWrite)
        {
            return false;
        }

        public bool Write(dynamic toWrite)
        {
            return false;
        }


        bool HandleWriteFailure(IAppArchive toWrite)
        {
            return false;
        }

        bool NotifyWriteFailure(IAppArchive wasWrite)
        {
            return false;
        }

        bool Write(IAppArchive toWrite)
        {
            return false;
        }
    }
}
