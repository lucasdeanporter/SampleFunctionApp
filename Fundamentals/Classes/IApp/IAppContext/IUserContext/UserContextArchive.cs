namespace SampleFunctionApp.Fundamentals.Classes.IApp.IAppContext.IUserContext
{
    internal class UserContextArchive //: IMethodContext
    {
        internal string userContextID = "Undefined. Not set.";

        string internalCorrelationID { get; set; }
    }
}
