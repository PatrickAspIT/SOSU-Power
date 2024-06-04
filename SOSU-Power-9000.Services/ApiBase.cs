using SOSU_Power_9000.Entities;
using System.Net.Http.Json;

namespace SOSU_Power_9000.Services
{
    public abstract class ApiBase
    {
        protected Uri baseUri;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;
        }

        protected ApiBase(string uri) : this(new Uri(uri))
        {
        }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            // Byg en URI for at sikre os at URL'en er korrekt
            url = "/api/" + url;
            Uri uri = new(baseUri, url);

            // Kald API'en
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);

            // returner resultatet til kalderen
            return response;
        }
    }

    public class SosuService : ApiBase, ISosuService
    {
        public SosuService(Uri baseUri) : base(baseUri) { }
        public SosuService(string baseUri) : base(baseUri) { }

        public async Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee)
        {
            string url = $"Task/GetTasksForEmployeeByDate?employeeId={employee.EmployeeId}&date={date.ToString("yyyy-MM-dd")}";
            var response = await GetHttpAsync(url);
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Entities.Task>();
            List<Entities.Task> tasks = await result.ToListAsync();
            return tasks;
        }
    }

    public interface ISosuService
    {
        Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee);
    }
}
