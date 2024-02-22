using ConsumeRestfulApi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ConsumeRestfulApi.Views.Books
{
    public partial class ViewBooks : Page
    {
        public ViewBooks()
        {
            InitializeComponent();
            LoadBooks();
        }

        private async void LoadBooks()
        {
            var books = await BookViewModel.GetBooks();
            dgBooks.DataContext = books.List;
        }

        private void BtnAddBook_Click(object sender, EventArgs e) 
        {
            NavigationService.Navigate(new AddBook());
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new EditBook((sender as FrameworkElement).DataContext));
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e) 
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                BookViewModel.DeleteBook(sender as FrameworkElement);
                LoadBooks();
            }
        }
    }
}
