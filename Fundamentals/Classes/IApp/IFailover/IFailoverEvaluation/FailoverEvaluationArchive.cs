using SampleFunctionApp.Fundamentals.Classes.IApp.IFailover.IFailover;
using SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppLog;
using SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppSessionContext;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp.IFailover.IFailoverEvaluation
{
    internal class FailoverEvaluationArchive : IChange
    {
        IAppSessionContext appSessionContext;
        FailoverContextArchive failureContext;
        ILogRecord logRecord;
        string IChange.Action { get; set; }
    }
}
