using SampleFunctionApp.Fundamentals.Classes.IExecution;
using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Classes.ITime;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using System;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppLogic : IAppLogic
    {
        public AppLogic()
        {
            //Console.WriteLine("Starting");
            relateId = Globals.GetTimeNow(); // set time in logic to set to records to correlate later in data.
            appLogicRecord = new AppLogicRecord();
            appLogicRecord.appRecord = new AppRecord();
            appLogicRecord.appRecord.appArchive = new AppArchive();
            appLogicRecord.appRecord.appArchive.relateId = relateId;
            appLogicRecord.appRecord.appArchive.Start = Globals.GetTimeNow();

            executionRecord = new ExecutionRecord();
            executionRecord.executionArchive = new ExecutionArchive();
            executionRecord.executionArchive.relateId = relateId;
            executionRecord.executionArchive.Start = Globals.GetTimeNow();

            appLogicRecord.timeRecord = new TimeRecord();
            appLogicRecord.timeRecord.timeArchive = new TimeArchive();
            appLogicRecord.timeRecord.timeArchive.relateId = relateId;
            appLogicRecord.timeRecord.timeArchive.Start = Globals.GetTimeNow();

            //Console.WriteLine("appLogicRecord", appLogicRecord);
        }

        public AppLogicRecord appLogicRecord { get; set; }
        public ExecutionRecord executionRecord { get; set; }
        public DateTime relateId { get; set; }
    }
}
