using ConsumeRestfulApi.Models;
using ConsumeRestfulApi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ConsumeRestfulApi.Views.Books
{
    public partial class EditBook : Page
    {
        private readonly Book _book;
        private readonly int _id;

        public EditBook(object DataContext)
        {
            _book = DataContext as Book;
            _id = _book.Id;
            InitializeComponent();
            txtTitle.Text = _book.Title;
            txtAuthor.Text = _book.Author;
            txtPrice.Text = _book.Price.ToString();
            dptxtLaunchDate.Text = _book.LaunchDate.ToString();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            DateTime launchDate = DateTime.Parse(dptxtLaunchDate.Text);
            BookViewModel.EditBook(_id, title, author, price, launchDate);
            NavigationService.GoBack();
        }
    }
}
