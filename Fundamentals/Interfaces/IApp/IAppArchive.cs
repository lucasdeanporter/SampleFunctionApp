using SampleFunctionApp.Fundamentals.Interfaces.IData;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    internal interface IAppArchive : IArchive, ITimeArchive, IChangeArchive
    {
    }
}
