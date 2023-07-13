using SampleFunctionApp.Fundamentals.Classes.IExecution;
using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Classes.ITime;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppLogic : IAppLogic
    {

        // Todo: Reduce duplication of information only if it makes it simpler. Duplication of data is to be expected because these are designs for backend data.
        
        public AppLogic(IAppLogicRecord appLogicRecord, GlobalsArchive globals)
        {
            appRelateId = globals.GetTimeNow();
            globals.appRelateId = appRelateId;

            this.appLogicRecord = appLogicRecord;

            executionLogic.executionId = globals.GetTimeNow();
            // Todo simplify and refactor
            executionLogic.ExecutionLogicRecord.timeRecord.timeArchive.Start = executionLogic.executionId;
            executionLogic.ExecutionLogicRecord.executionRecord.executionArchive.HasNetwork = true;
        }

        public async ValueTask<dynamic> PingTest()
        {
            return await appLogicRecord.PingTest("http://microsoft.com");
        }

        public IAppLogicRecord appLogicRecord { get; set; }
        public DateTime appRelateId { get; set; }
        public IExecutionLogic executionLogic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
