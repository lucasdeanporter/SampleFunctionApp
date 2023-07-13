using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    public class ExecutionLogic : IExecutionLogic
    {
        private readonly GlobalsArchive globalsArchive;
        public ExecutionLogic(IExecutionLogicRecord executionLogicRecord, GlobalsArchive globalsArchive) 
        {
            this.executionLogicRecord = executionLogicRecord;
            this.globalsArchive = globalsArchive; 
        }
        public DateTime executionId { get; set; }
        public IExecutionLogicRecord executionLogicRecord { get; set; }

        public bool Start()
        {
            executionId = globalsArchive.GetTimeNow();
            executionLogicRecord.timeRecord.timeArchive.Start = executionId;
            executionLogicRecord.executionRecord.executionArchive.executionId = executionId;
            return true;
        }
        public bool Stop()
        {
            executionLogicRecord.timeRecord.timeArchive.End = globalsArchive.GetTimeNow();
            return true;
        }
        public bool SetNetwork(string url)
        {
            this.executionLogicRecord.executionRecord.executionArchive.HasNetwork = true;
            this.executionLogicRecord.executionRecord.executionArchive.networkURL = url;
            return true;
        }
    }
}
