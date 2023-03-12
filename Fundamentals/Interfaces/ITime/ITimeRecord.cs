using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.ITime
{
    internal interface ITimeRecord
    {
        public ITimeArchive;
        public static DateTime GetTime => DateTime.UtcNow;



        private void Start();
        public void End();

        public static DateTime End { get => DateTime.UtcNow; }
        public static DateTime Start { get => start; set => start = value; }
    }
}
