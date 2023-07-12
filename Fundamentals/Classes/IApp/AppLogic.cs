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
        public AppLogic(IAppLogicRecord appLogicRecord)
        {
            //Console.WriteLine("Starting");
            relateId = Globals.GetTimeNow(); // set time in logic to set to records to correlate later in data.
            

            appLogicRecord.appRecord.appArchive.relateId = relateId;

            executionRecord = new ExecutionRecord();
            executionRecord.executionArchive = new ExecutionArchive();
            executionRecord.executionArchive.relateId = relateId;

            executionRecord.timeRecord = new TimeRecord();
            executionRecord.timeRecord.timeArchive = new TimeArchive();
            executionRecord.timeRecord.timeArchive.relateId = relateId;
            executionRecord.timeRecord.timeArchive.Start = Globals.GetTimeNow();

            //Console.WriteLine("appLogicRecord", appLogicRecord);
        }

        public async ValueTask<dynamic> PingTest()
        {
            return await appLogicRecord.PingTest("https://github.com/lucasdeanporter/SampleFunctionApp");
        }

        public IAppLogicRecord appLogicRecord { get; set; }
        public IExecutionRecord executionRecord { get; set; }
        public DateTime relateId { get; set; }
    }
}
