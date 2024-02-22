using System.Windows;
using System.Windows.Input;

namespace ConsumeRestfulApi.Views
{
    public partial class Dashboard : Window
    {
        internal Dashboard()
        {
            InitializeComponent();
        }
        
        private void WDashboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void WDashboard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                if(WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                    Width = 800;
                    Height = 450;
                }
                else
                {
                    WindowState = WindowState.Maximized;
                }
            }
        }

        private void BtnBooks_Click(object sender, RoutedEventArgs e)
        {
            dashboardFrame.Navigate(new Books.ViewBooks());
        }

        private void BtnPersons_Click(object sender, RoutedEventArgs e)
        {
            dashboardFrame.Navigate(new Persons.ViewPersons());
        }
    }
}
