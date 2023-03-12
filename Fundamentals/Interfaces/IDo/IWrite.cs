namespace SampleFunctionApp.Fundamentals.Interfaces.IDo
{
    public interface IWrite : IDo
    {
        // Intended logic to save data in some manner.
        public bool Write(dynamic toWrite);
        public bool WriteFailure(dynamic toWrite);
        public void NotifyWriteFailure(dynamic wasWrite);
    }
}
