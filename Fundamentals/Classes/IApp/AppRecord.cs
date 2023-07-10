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
    internal class AppRecord : IAppRecord
    {
        IAppArchive IAppRecord.appArchive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ITimeArchive ITimeRecord.timeArchive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IRelate.RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IWrite.NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.WriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
