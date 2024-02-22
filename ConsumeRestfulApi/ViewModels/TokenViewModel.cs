using ConsumeRestfulApi.Models;
using ConsumeRestfulApi.ViewModels.Base;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows;

namespace ConsumeRestfulApi.ViewModels
{
    class TokenViewModel : BaseViewModel
    {
        private static Token? _token;

        public static async Task SignIn(User user)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsJsonAsync("auth/v1/signin", user);
                if (!ResponseValidation(response)) return;
                string token = await response.Content.ReadAsStringAsync();
                _token = JsonConvert.DeserializeObject<Token>(token);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token.AcessToken);
            }
            catch (Exception)
            {
                MessageBox.Show("Authentication service is offline");
            }
        }

        public static bool IsLogged()
        {
            if (_token is not null) return true;
            return false;
        }
        private static bool ResponseValidation(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Please, insert the correct credentials", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
