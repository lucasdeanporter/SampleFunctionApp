using SampleFunctionApp.Fundamentals.Classes.IApp.IAppContext.IMethodContext;
using SampleFunctionApp.Fundamentals.Features;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System.Collections.Generic;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppLog
{
    public interface ILogArchive : ISessionArchive, IDurationArchive, IArchive, ILog
    {
        List<string> AllMessages { get; set; }
        string NamespaceName { get; set; }
        string ClassName { get; set; }
        string MethodName { get; set; }
        public object BeginningParameters { get; set; }
        public object EndingParameters { get; set; }
        public int EndIncrement { get; set; }
        public bool OnMethodEndCalled { get; set; }
        public bool IsMethodEnd { get; set; }
    }
}