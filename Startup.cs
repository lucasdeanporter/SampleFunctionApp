using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SampleFunctionApp.Fundamentals.Classes.IApp;
using SampleFunctionApp.Fundamentals.Classes.IExecution;
using SampleFunctionApp.Fundamentals.Classes.IGeneral;
using SampleFunctionApp.Fundamentals.Classes.ITime;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;

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
            builder.Services.AddTransient<IAppLogic, AppLogic>();
            builder.Services.AddTransient<IAppLogicRecord, AppLogicRecord>();
            builder.Services.AddTransient<IAppRecord, AppRecord>();
            builder.Services.AddTransient<IAppArchive, AppArchive>();

            builder.Services.AddTransient<IExecutionLogic, ExecutionLogic>();
            builder.Services.AddTransient<IExecutionLogicRecord, ExecutionLogicRecord>();
            builder.Services.AddTransient<IExecutionRecord, ExecutionRecord>();
            builder.Services.AddTransient<IExecutionArchive, ExecutionArchive>();

            builder.Services.AddTransient<ITimeRecord, TimeRecord>();
            builder.Services.AddTransient<ITimeArchive, TimeArchive>();

            builder.Services.AddSingleton<GlobalsArchive>();
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
