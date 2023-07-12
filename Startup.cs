using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SampleFunctionApp.Fundamentals.Classes.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;

// TODO: Async challenges, not a challenge: https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios#wait-for-multiple-tasks-to-complete
// https://en.wikipedia.org/wiki/Referential_transparency
// https://devblogs.microsoft.com/dotnet/understanding-the-whys-whats-and-whens-of-valuetask/

// https://learn.microsoft.com/en-us/azure/azure-functions/functions-dotnet-dependency-injection
[assembly: FunctionsStartup(typeof(SampleFunctionApp.Startup))]

namespace SampleFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
        // https://learn.microsoft.com/en-us/dotnet/core/extensions/httpclient-factory#basic-usage
            builder.Services.AddHttpClient();
            builder.Services.AddSingleton<IAppLogic, AppLogic>();
            builder.Services.AddSingleton<IAppLogicRecord, AppLogicRecord>();
            builder.Services.AddSingleton<IAppRecord, AppRecord>();
            builder.Services.AddSingleton<IAppArchive, AppArchive>();
            /*
            builder.Services.AddHttpClient();

            builder.Services.AddSingleton<IMyService>((s) => {
                return new MyService();
            });

            builder.Services.AddSingleton<ILoggerProvider, MyLoggerProvider>();
            */
        }
    }
}
