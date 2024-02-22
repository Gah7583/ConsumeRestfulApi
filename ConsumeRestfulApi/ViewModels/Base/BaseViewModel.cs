using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsumeRestfulApi.ViewModels.Base
{
    internal class BaseViewModel
    {
        protected static readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("https://localhost:7267/api/")
        };
    }
}
