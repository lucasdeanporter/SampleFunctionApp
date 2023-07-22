using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    internal class AppDisplay : IAppDisplay
    {
        public AppDisplay(IAppLogic appLogic) 
        {
            this.AppLogic = appLogic;
        }
        public IAppLogic AppLogic { get; set; }
        public dynamic Message { get; set; }
    }
}
