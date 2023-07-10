using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IData;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    internal class AppArchive : IAppArchive
    {
        string IChangeArchive.CreatedByUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IChangeArchive.CreatedByTimestamp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IChangeArchive.ModifiedByUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IChangeArchive.ModifiedByTimestamp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IChange.Action { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime ITimeArchive.Start { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime ITimeArchive.End { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        long IRelate.RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
