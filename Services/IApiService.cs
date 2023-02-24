using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public interface IApiService
    {
        Task<RootModel> getData(string id);
    }
}
