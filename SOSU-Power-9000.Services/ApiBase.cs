using Azure.Core;
using System.Net;
using System.Net.Http.Json;

using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.Services
{
    public abstract class ApiBase
    {
        protected Uri baseUri;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;
        }

        protected ApiBase(string uri) : this(new Uri(uri)) { }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            // Byg en URI for at sikre os at URL'en er korrekt.
            Uri uri = new("");

            // Kald Api'et
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);

            // Returner resultatet til kalderen
            return response;
        }
    }

    public class SosuService : ApiBase, ISosuService
    {
        public SosuService(Uri baseUri) : base(baseUri) { }
        public SosuService(string baseUri) : base(baseUri) { }

        public async Task<List<Entities.Task>> GetAssignmentsForAsync(DateTime date, Employee employee)
        {
            string url = "";
            var response = await GetHttpAsync(url);
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Assignment>();
            List<Entities.Task> tasks = await result.ToListAsync();
            return tasks;
        }
    }

    public interface ISosuService
    { 
        Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee);
    }
}