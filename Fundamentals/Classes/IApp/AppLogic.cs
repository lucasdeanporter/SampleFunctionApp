using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;

using System;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppLogic : IAppLogic
    {        
        public AppLogic(IAppLogicRecord appLogicRecord, IExecutionLogic executionLogic, GlobalsArchive globals)
        {
            appRelateId = globals.GetTimeNow();
            globals.appRelateId = appRelateId;

            this.executionLogic = executionLogic;
            this.executionLogic.Start();

            this.appLogicRecord = appLogicRecord;

            this.executionLogic.Stop();
            // Todo simplify and refactor
            //executionLogic.ExecutionLogicRecord.executionRecord.executionArchive.HasNetwork = true;
        }

        public async ValueTask<dynamic> PingTest()
        {
            return await appLogicRecord.PingTest("http://microsoft.com");
        }

        public IAppLogicRecord appLogicRecord { get; set; }
        public DateTime appRelateId { get; set; }
        public IExecutionLogic executionLogic { get; set; }
    }
}
