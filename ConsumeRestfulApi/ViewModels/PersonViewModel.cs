using ConsumeRestfulApi.Models;
using ConsumeRestfulApi.ViewModels.Base;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows;

namespace ConsumeRestfulApi.ViewModels
{
    internal class PersonViewModel : BaseViewModel
    {
        private static readonly string _baseUrl = "persons/v1/";

        public static async Task<PagedSearch<Person>> GetPersons()
        {
            var response = await _httpClient.GetStringAsync($"{_baseUrl}desc/10/1");
            var persons = JsonConvert.DeserializeObject<PagedSearch<Person>>(response);
            return persons;
        }



        public static async void DeletePerson(FrameworkElement button)
        {
            int id = (button.DataContext as Person).Id; 
            await _httpClient.DeleteAsync($"{_baseUrl}?id={id}");
        }

        public static async void AddPerson(string firstName, string lastName, string address, string gender)
        {
            Person person = new() {
                Id = 0,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Gender = gender,
                Enabled = true
            };
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_baseUrl, person);
            response.EnsureSuccessStatusCode();
        }

        public static async void EditPerson(int id , string firstName, string lastName, string address, string gender, bool enabled)
        {
            Person person = new()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Gender = gender,
                Enabled = enabled
            };
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync(_baseUrl, person);
            response.EnsureSuccessStatusCode();
        }
    }
}
