using BlazorWebApp.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorWebApp.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;

        public ApiService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<IEnumerable<ApiModel>> getData(string id)
        {
            Console.Write(id);
            await using Stream stream = await httpClient.GetStreamAsync($"https://www3.septa.org/api/TransitView/index.php/{id}"); 
            return await JsonSerializer.DeserializeAsync<ApiModel[]>(stream); ;
        }

       
    }
}
