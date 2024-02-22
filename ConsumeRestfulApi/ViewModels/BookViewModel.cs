using ConsumeRestfulApi.Models;
using ConsumeRestfulApi.ViewModels.Base;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Windows;

namespace ConsumeRestfulApi.ViewModels
{
    internal class BookViewModel : BaseViewModel
    {
        private static readonly string _baseUrl = "books/v1/";
        public static async Task<PagedSearch<Book>> GetBooks()
        {
            var response = await _httpClient.GetStringAsync($"{_baseUrl}desc/10/1");
            var books = JsonConvert.DeserializeObject<PagedSearch<Book>>(response);
            return books;
        }

        public static async void DeleteBook(FrameworkElement book)
        {
            int id = (book.DataContext as Book).Id;
            await _httpClient.DeleteAsync($"{_baseUrl}?id={id}");
        }

        public static async void AddBook(string title, string author, decimal price, DateTime launchDate)
        {
            Book book = new()
            {
                Title = title,
                Author = author,
                Price = price,
                LaunchDate = launchDate
            };
            var response = await _httpClient.PostAsJsonAsync(_baseUrl, book);
            response.EnsureSuccessStatusCode();
        }

        public static async void EditBook(int id, string title, string author, decimal price, DateTime launchDate)
        {
            Book book = new()
            {
                Id = id,
                Title = title,
                Author = author,
                Price = price,
                LaunchDate = launchDate
            };
            var response = await _httpClient.PutAsJsonAsync(_baseUrl, book);
            response.EnsureSuccessStatusCode();
        }
    }
}
