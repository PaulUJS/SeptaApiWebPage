using BlazorWebApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorWebApp.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;

        public ApiService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<RootModel> getData(string id)
        {
   
            string response = await httpClient.GetStringAsync($"https://www3.septa.org/api/TransitView/index.php/{id}");
            RootModel data = JsonConvert.DeserializeObject<RootModel>(response);
            return data;
        }

       
    }
}
