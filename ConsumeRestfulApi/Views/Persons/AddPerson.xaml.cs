using ConsumeRestfulApi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ConsumeRestfulApi.Views.Persons
{
    public partial class AddPerson : Page
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress.Text;
            string gender = txtGender.Text;
            PersonViewModel.AddPerson(firstName, lastName, address, gender);
            NavigationService.GoBack();
        }
    }
}
