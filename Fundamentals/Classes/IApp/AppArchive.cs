using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IData;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppArchive : IAppArchive, ITimeArchive
    {

        public AppArchive()
        {
            AppName = Globals.AppName;
            AppSessionID = AppName + Globals.GenerateGUIDValue(); // Takes into account specific application instances rather than timestamps.
        }

        public string AppSessionID { get; set; }
        public string AppName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string RelateId { get; set; }
    }
}
