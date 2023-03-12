namespace SampleFunctionApp.Fundamentals.Interfaces.IDo
{
    public interface IReadWrite : IWrite, IRead, IDo
    {
        // Intended to have logic intended for writing and reading.
    }
}
