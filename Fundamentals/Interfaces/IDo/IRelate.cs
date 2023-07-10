namespace SampleFunctionApp.Fundamentals.Interfaces.IDo
{
    public interface IRelate : IDo
    {
        // Intended to identify from one place to another across variables or objects. Such as to map two IArchives together, like how relational databases are designed.

        // Primarily used with ITimeArchive to correlate multiple data points using timestamps converted to strings.
        string RelateId { get; set; }
    }
}
