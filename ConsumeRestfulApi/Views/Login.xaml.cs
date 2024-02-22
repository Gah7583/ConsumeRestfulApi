using ConsumeRestfulApi.Models;
using ConsumeRestfulApi.ViewModels;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ConsumeRestfulApi.Views;

public partial class Login : Window
{
    public Login()
    {
        InitializeComponent();
    }


    private void WLogin_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if(e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }
    }
    private void WLogin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if(e.ClickCount == 2)
        {
            if (WindowState == WindowState.Maximized)
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

    private async void BtnLogin_Click(object sender, RoutedEventArgs e)
    {
        if (txtUsername.Text == "" | pbPassword.Password == "")
        {
            MessageBox.Show("Please, insert username and password", "Insert credentials", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        User user = new()
        {
            UserName = txtUsername.Text,
            Password = pbPassword.Password
        };
        await TokenViewModel.SignIn(user);
        if (!TokenViewModel.IsLogged()) return;
        Dashboard dashboard = new();
        dashboard.Show();
        dashboard.Activate();
        Close();
    }

    private void BtnLogin_MouseEnter(object sender, MouseEventArgs e)
    {
        btnLogin.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3F89AE"));
    }

    private void BtnLogin_MouseLeave(object sender, MouseEventArgs e)
    {
        btnLogin.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF357392"));
    }

    private void TxtUsername_GotFocus(object sender, RoutedEventArgs e)
    {
        txtUsernameBorder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF55567B"));
    }

    private void TxtUsername_LostFocus(object sender, RoutedEventArgs e)
    {
        txtUsernameBorder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF545AEA"));
    }

    private void PbPassword_GotFocus(object sender, RoutedEventArgs e)
    {
        pbPasswordBorder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF55567B"));
    }

    private void PbPassword_LostFocus(object sender, RoutedEventArgs e)
    {
        pbPasswordBorder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF545AEA"));
    }
}