using ConsumeRestfulApi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ConsumeRestfulApi.Views.Books
{
    public partial class AddBook : Page
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            DateTime launchDate = DateTime.Parse(dpLaunchDate.Text);
            BookViewModel.AddBook(title, author, price, launchDate);
            NavigationService.GoBack();
        }
    }
}
