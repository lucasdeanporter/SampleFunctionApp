namespace SampleFunctionApp.Classes.IAppSessionContext
{
    public class AppRuntimeArchive
    {
        AppStartArchive Start { get; set; }
        AppEndArchive End { get; set; }

        AppRuntimeArchive(AppStartArchive start, AppEndArchive end)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
