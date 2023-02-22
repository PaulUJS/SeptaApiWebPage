using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public interface IApiService
    {
        Task<IEnumerable<ApiModel>> getData(string id);
    }
}
