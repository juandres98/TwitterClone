using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwitterClone.Views;
using Xamarin.Forms;

namespace TwitterClone.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () =>
            {
                var Users = await Locator.Database.GetUsers();
                var ValidateUser = await Locator.Database.ValidateUser(Name, Password);
                if(ValidateUser == 1)
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new MenuPrincipal());
                }
            });
        }

        private string name = String.Empty;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                var args = new PropertyChangedEventArgs(nameof(name));
                PropertyChanged?.Invoke(this, args);
            }
        }

        private string password = String.Empty;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                var args = new PropertyChangedEventArgs(nameof(password));
                PropertyChanged?.Invoke(this, args);
            }
        }
    }
}
