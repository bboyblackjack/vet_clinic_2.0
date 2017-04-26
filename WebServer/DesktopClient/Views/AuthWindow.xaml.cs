using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using RestSharp;
using DesktopClient.ViewModels;
using DesktopClient.Services;

namespace DesktopClient.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private RestClient _restClient;

        public AuthWindow()
        {
            InitializeComponent();

            _restClient = new RestClient("http://localhost:53444/");
        }

        

        private void Auth(string login, string password)
        {
            var model = new AuthViewModel
            {
                Email = login,
                Password = password
            };

            var request = new RestRequest("api/account", Method.POST);

            request.AddJsonBody(model);

            var result = _restClient.Execute(request).Content;
            if (result != "null" && result.Split(';')[2].Contains("Doctor"))
            {
                AuthService.CreateAuthService(result.Split(';')[0], result.Split(';')[1]);

                var mainWindow = new MainWindow();
                mainWindow.Show();

                Close();
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }
        }

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            Auth(Login.Text, Password.Password);
        }
    }
}
