using SampleFunctionApp.Classes.IFailover.IFailover;
using SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppLog;
using SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppSessionContext;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Classes.IFailover.IFailoverEvaluation
{
    internal class FailoverEvaluationArchive : IChange
    {
        IAppSessionContext appSessionContext;
        FailoverContextArchive failureContext;
        ILogRecord logRecord;
        string IChange.Action { get; set; }
    }
}
