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
        public AppLogic(IAppLogicRecord appLogicRecord, IExecutionRecord executionRecord, Globals globals)
        {
            //Console.WriteLine("Starting");
            relateId = globals.GetTimeNow(); // set time in logic to set to records to correlate later in data.
            
            this.appLogicRecord = appLogicRecord;
            this.executionRecord = executionRecord;
            this.executionRecord.executionArchive.HasNetwork = false;
            this.executionRecord.executionArchive.relateId = relateId;

            appLogicRecord.appRecord.appArchive.relateId = relateId;
            appLogicRecord.timeRecord.timeArchive.relateId = relateId;
            appLogicRecord.executionRecord.executionArchive.relateId = relateId;

            appLogicRecord.timeRecord.timeArchive.Start = globals.GetTimeNow();

            //Console.WriteLine("appLogicRecord", appLogicRecord);
        }

        public async ValueTask<dynamic> PingTest()
        {
            return await appLogicRecord.PingTest("http://microsoft.com");
        }

        public IAppLogicRecord appLogicRecord { get; set; }
        public IExecutionRecord executionRecord { get; set; }
        public DateTime relateId { get; set; }
    }
}
