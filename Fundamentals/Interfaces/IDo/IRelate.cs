namespace SampleFunctionApp.Fundamentals.Interfaces.IDo
{
    public interface IRelate : IDo
    {
        // Intended to identify from one place to another across variables or objects. Such as to map two IArchives together, like how relational databases are designed.
        string RelateId { get; set; }
    }
}
