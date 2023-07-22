using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppDisplay
    {
        IAppLogic AppLogic { get; set; }
        dynamic Message { get; set; }
    }
}
