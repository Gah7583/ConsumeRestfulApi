using ConsumeRestfulApi.Models;
using ConsumeRestfulApi.ViewModels;
using System.Windows.Controls;

namespace ConsumeRestfulApi.Views.Persons
{
    public partial class EditPerson : Page
    {
        private readonly Person _person;
        private readonly int _id;
        public EditPerson(object dataContext)
        {
            _person = (dataContext as Person);
            _id = _person.Id;
            InitializeComponent();
            txtFirstName.Text = _person.FirstName;
            txtLastName.Text = _person.LastName;
            txtAddress.Text = _person.Address;
            txtGender.Text = _person.Gender;
            chkEnabled.IsChecked = _person.Enabled;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress.Text;
            string gender = txtGender.Text;
            bool enabled = chkEnabled.IsChecked.Value;
            PersonViewModel.EditPerson(_id, firstName, lastName, address, gender, enabled);
            NavigationService.GoBack();
        }
    }
}
