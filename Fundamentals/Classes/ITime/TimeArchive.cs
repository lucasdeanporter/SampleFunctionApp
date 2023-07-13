using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;

namespace SampleFunctionApp.Fundamentals.Classes.ITime
{
    public class TimeArchive : ITimeArchive
    {

        private readonly GlobalsArchive globalsArchive;
        public TimeArchive(GlobalsArchive globalsArchive) 
        { 
            this.globalsArchive = globalsArchive;
            Start = null;
        }
        public DateTime appRelateId { get => globalsArchive.appRelateId; }
        public DateTime End { get; set; }
        public DateTime? Start { get; set; }
    }
}
