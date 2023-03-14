namespace SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppSessionContext
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
