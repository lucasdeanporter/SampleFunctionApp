using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using SampleFunctionApp.Fundamentals.Interfaces.IExecution;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppLogicRecord : IAppLogicRecord
    {
        IHttpClientFactory httpClientFactory;
        public AppLogicRecord(IHttpClientFactory httpClientFactory, IAppRecord appRecord, IExecutionRecord executionRecord, ITimeRecord timeRecord) 
        {
            this.httpClientFactory = httpClientFactory;
            this.appRecord = appRecord;
            this.executionRecord = executionRecord;
            this.timeRecord = timeRecord;
            this.executionRecord.executionArchive.HasNetwork = true;

        }

        public ITimeRecord timeRecord { get; set; }
        public IAppRecord appRecord { get; set; }
        public IExecutionRecord executionRecord { get; set; }
        public async Task<dynamic> PingTest(string url)
        {
            using HttpClient client = httpClientFactory.CreateClient();
            try
            {
                return await client.GetAsync(url);
            }
            catch
            {
                return null;
            }
        }

        public bool HandleWriteFailure(dynamic toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(dynamic wasWrite)
        {
            return false;
        }

        public bool Write(dynamic toWrite)
        {
            return false;
        }

        public bool HandleWriteFailure(IAppRecord toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(IAppRecord wasWrite)
        {
            return false;
        }

        public bool Write(IAppRecord toWrite)
        {
            return false;
        }

        public bool HandleWriteFailure(IExecutionRecord toWrite)
        {
            return false;
        }

        public bool NotifyWriteFailure(IExecutionRecord wasWrite)
        {
            return false;
        }

        public bool Write(IExecutionRecord toWrite)
        {
            return false;
        }
    }
}
