using System;

namespace SampleFunctionApp.Fundamentals.Classes.IGeneral
{
    public static class Globals
    {
        public static DateTime GetTimeNow()
        {
            return DateTime.UtcNow;
        }
        public static string ProjectFileRelativePath = "relative/path";
        private static Guid Guid = Guid.NewGuid();
        public static string AppName = "Application Telescope";
        public static string GenerateGUIDValue()
        {
            return Guid.ToString();
        }
    }
}
