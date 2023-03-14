using SampleFunctionApp.Fundamentals.Interfaces.Concepts;

namespace SampleFunctionApp.Fundamentals.Interfaces.IDo
{
    public interface IChange : IDo, ICRUD
    {
        // Actions intended to label data to associate for backend jobs, like Azure Functions, such as for databases. Can be used to defer work for later.
        enum ActionDefinitions { }
        string Action { get; set; }
    }
}
