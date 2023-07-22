using SampleFunctionApp.Fundamentals.Interfaces.IApp;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Classes.IApp
{
    public class AppRecord : IAppRecord
    {
        IHttpClientFactory httpClientFactory;
        public AppRecord(IAppArchive appArchive, IHttpClientFactory httpClientFactory) 
        {
            this.httpClientFactory = httpClientFactory;
            this.appArchive = appArchive;
        }
        public IAppArchive appArchive { get; set; }

        public async ValueTask<bool> GetAsyncArchive(string url)
        {
            using HttpClient client = httpClientFactory.CreateClient();
            try
            {
                appArchive = await client.GetFromJsonAsync<IAppArchive>(url);
                return true;
            }
            catch
            {
                return false;
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


        bool HandleWriteFailure(IAppArchive toWrite)
        {
            return false;
        }

        bool NotifyWriteFailure(IAppArchive wasWrite)
        {
            return false;
        }

        bool Write(IAppArchive toWrite)
        {
            return false;
        }
    }
}
