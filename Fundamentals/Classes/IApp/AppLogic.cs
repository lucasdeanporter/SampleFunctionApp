using SampleFunctionApp.Fundamentals.Classes.IExecution;
using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using System;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    internal class AppLogic : IAppLogic
    {
        AppLogic()
        {
            relateId = Globals.GetTimeNow(); // set time in logic to set to records to correlate later in data.
            appLogicRecord = new AppLogicRecord();
            executionRecord = new ExecutionRecord();
        }

        public IAppLogicRecord appLogicRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IExecutionRecord executionRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime relateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
