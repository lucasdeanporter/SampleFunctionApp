using SampleFunctionApp.Fundamentals.Interfaces.IData;
using SampleFunctionApp.Fundamentals.Interfaces.IDo;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppArchive : IArchive, ITimeArchive
    {
        public string AppSessionID { get; set; }
        public string AppName { get; set; }
    }
}
