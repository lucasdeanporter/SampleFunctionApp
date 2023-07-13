using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using System;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppArchive : IAppArchive
    {
        public string AppName { get => GlobalsArchive.AppName; }
        public DateTime relateId { get; set; }
    }
}
