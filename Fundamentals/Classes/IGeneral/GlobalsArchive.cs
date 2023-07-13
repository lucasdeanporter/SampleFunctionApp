using System;

namespace SampleFunctionApp.Fundamentals.Classes.IGeneral
{
    public class GlobalsArchive
    {
        public DateTime appRelateId;
        public DateTime GetTimeNow()
        {
            return DateTime.UtcNow;
        }
        public string ProjectFileRelativePath = "relative/path";
        private Guid Guid = Guid.NewGuid();
        public string AppName = "Application Telescope";
        public string GenerateGUIDValue()
        {
            return Guid.ToString();
        }
    }
}
