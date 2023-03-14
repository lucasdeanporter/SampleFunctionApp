namespace SampleFunctionApp.Fundamentals.Interfaces.IContexts.IAppSessionContext
{
    public class AppRuntimeArchive
    {
        AppStartArchive Start { get; set; }
        AppEndArchive End { get; set; }

        AppRuntimeArchive(AppStartArchive start, AppEndArchive end)
        {
            Start = start;
            End = end;
        }
    }
}
