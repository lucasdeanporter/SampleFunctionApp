using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IGeneral
{
    public static class Globals
    {
        public static string ProjectFileRelativePath = "relative/path";
        private static Guid Guid = Guid.NewGuid();
        public static string AppId = "AppName";
        public static string GenerateGUIDValue()
        {
            return Guid.ToString();
        }
    }
}
