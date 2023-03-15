using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp.IAppContext.IAppContext
{
    internal class AppContextArchive : IArchive, IChange
    {
        public long RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IChange.Action { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
