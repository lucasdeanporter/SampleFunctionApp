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
        AppRecord()
        {

        }
        IAppArchive IAppRecord.appArchive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IExecutionRecord IRecord.executionRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IWrite.HandleWriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
