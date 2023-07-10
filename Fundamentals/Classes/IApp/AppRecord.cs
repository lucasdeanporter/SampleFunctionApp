using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
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
        AppRecord()
        {
            appArchive = new AppArchive();
        }

        public IAppArchive appArchive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ITimeRecord timeRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }

        public bool Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        public bool WriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
