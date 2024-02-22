using ConsumeRestfulApi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ConsumeRestfulApi.Views.Persons
{
    public partial class ViewPersons : Page
    {
        public ViewPersons()
        {
            InitializeComponent();
            LoadPersons();
        }

        private async void LoadPersons()
        {
            var persons = await PersonViewModel.GetPersons();
            dgPersons.DataContext = persons.List;
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new AddPerson());
        }

        private void BtnEditPerson_Click(object sender, EventArgs e) 
        {
            NavigationService.Navigate(new EditPerson((sender as FrameworkElement).DataContext));
        }

        private void BtnDeletePerson_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this person?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                PersonViewModel.DeletePerson(sender as FrameworkElement);
                LoadPersons();
            }
        }
    }
}
