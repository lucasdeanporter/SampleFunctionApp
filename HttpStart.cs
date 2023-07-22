using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Classes.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.Concepts;
using System.Net.Http;
namespace SampleFunctionApp
{
    public class HttpStart
    {
        IAppLogic appLogic;
        IAppDisplay appDisplay;

        public HttpStart(IAppLogic appLogic, IAppDisplay appDisplay)
        {
            this.appLogic = appLogic;
            this.appDisplay = appDisplay;
        }

        [FunctionName("HttpStart")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            dynamic message = await appLogic.PostAsyncArchive("https://microsoft.com");
            appDisplay.AppLogic = appLogic;
            appDisplay.Message = message;
            //return new OkObjectResult(appLogic);
            return new OkObjectResult(appDisplay);
        }
    }
}
/*
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log, AppLogic appLogic)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";


            ValueTask<dynamic> taskResult = await appLogic.PingTest();

            return new OkObjectResult(taskResult);
        }


    }
}
*/