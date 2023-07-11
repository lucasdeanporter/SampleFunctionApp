namespace SampleFunctionApp.Fundamentals.Interfaces.IDo
{
    public interface IWrite : IDo
    {
        // Intended logic to save data in some manner.
        public bool Write(dynamic toWrite);
        public bool HandleWriteFailure(dynamic toWrite);
        public bool NotifyWriteFailure(dynamic wasWrite);
    }
}
