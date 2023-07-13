using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using System;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppArchive : IAppArchive
    {
        private readonly GlobalsArchive globalsArchive;
        public AppArchive(GlobalsArchive globalsArchive) { this.globalsArchive = globalsArchive; }
        public DateTime appRelateId { get => globalsArchive.appRelateId; }
        public string AppName { get => globalsArchive.AppName; }
    }
}
