using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace W_Project.UserLogin
{
    public class UserLoginViewModel : INotifyPropertyChanged
    {

        #region Cktor
        public UserLoginViewModel() 
        {
            LoginCommand = new Command(LoginClicked);
        }
        #endregion
        #region Propertys

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; set; }
        #endregion


        // Message to ViewModel it has was Changed in the View
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private async void LoginClicked()
        {
            
            if(!string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Fehler", "Benutzername und Passwort falsch", "Ok");
                return;
            }

            if(UserName == "admin" && Password == "password")
            {
                 Application.Current.MainPage = new MainPage();
                 
            }


        }
    }
}
