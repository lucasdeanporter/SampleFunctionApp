using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using System;
using System.Collections.Generic;

namespace SampleFunctionApp.Fundamentals.Classes.IExecution
{
    internal class ExecutionArchive : IExecutionArchive
    {
        private readonly GlobalsArchive globalsArchive;
        public ExecutionArchive(GlobalsArchive globalsArchive) { this.globalsArchive = globalsArchive; }
        public DateTime appRelateId { get => globalsArchive.appRelateId; }
        public DateTime executionId { get; set; }
        public bool HasNetwork { get; set; }
        public bool HasUser { get; set; }
        public bool HasError { get; set; }
        public List<string> Steps { get; set; }
    }
}
