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
    internal class AppArchive : IAppArchive
    {

        AppArchive()
        {
            Start = DateTime.Now;
            RelateId = this.Start.ToString();
        }

        public DateTime Start { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime End { get; set; }
        public string RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
