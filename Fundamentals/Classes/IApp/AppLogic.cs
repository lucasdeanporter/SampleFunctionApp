using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.IGeneral;
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
        }

        public async ValueTask<dynamic> PostAsyncArchive(string url)
        {
            this.executionLogic.SetNetwork(url);
            return await appLogicRecord.PostAsyncArchive(url);
        }

        public IAppLogicRecord appLogicRecord { get; set; }
        public DateTime appRelateId { get; set; }
        public IExecutionLogic executionLogic { get; set; }
    }
}
