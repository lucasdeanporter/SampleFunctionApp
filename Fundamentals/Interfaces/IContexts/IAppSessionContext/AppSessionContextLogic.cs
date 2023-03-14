using SampleFunctionApp.Fundamentals.Interfaces.IGeneral;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IContexts.IAppSessionContext
{
    internal class AppSessionContextLogic : IMediator
    {
        private AppSessionContextLogicRecord logicRecord = null;

        AppSessionContextRecord _record; // Conglomerates a lot of other features when saving to database. Also serves Logic layer.
        AppSessionContextLogic _logic; // Does things closer to presenting information to other service and features.

        // This Logic layer pulls everything together at a higher level than just a record level in this case, as it is complex code.
        // We can use this to repeat other functions elsewhere in the code if it is hard to get to, for whatever the infinite reasons.
        internal AppSessionContextLogic(AppSessionContextLogicRecord appSessionService)
        {
            if (appSessionService != null)
            {
                try
                {
                    logicRecord = appSessionService;
                    /*
                    if (logicRecord.AppStartTimestamp != null)
                    {

                    }
                    else
                    {
                        // TODO: Do something when things are accessed weirdly. Let users know.
                        // TODO: Log that loginRecord did not start up correctly.
                    }
                    */
                }
                catch
                {
                    // This is where it gets annoying.
                    try { }
                    catch { }
                    finally { }
                }
                finally
                {
                    // Just give them what they want another way?
                }
            }
            else
            {
                throw new Exception("AppSessionContextLogicRecord not properly set as a singleton in Program.cs configuring it as a service.");
            }
        }


    }
}
