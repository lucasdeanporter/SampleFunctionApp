using SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppSessionContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp.IFailover.IFailover
{
    internal class FailoverContextArchive
    {
        public bool? isPublicIPAddress = null;
        public bool? isPrimaryResource = null;
        public bool? isSecondaryResource = null;
        IAppSessionContext appSessionContext;
    }
}
