using SkiaSharp.Extended.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace W_Project.ViewModels
{
    internal class LoginViewModel
    {
        public LoginViewModel()
        {
            LoginCommand = new Command(async (parameter) => await ButtonClicked_Execute(parameter));
        }

        private bool _lottieIsVisible;
        public bool LottieIsVisible
        {
            get => _lottieIsVisible;
            set
            {
                _lottieIsVisible = value;
                OnPropertyChanged(nameof(LottieIsVisible));
            }
        }
        public Animation lottieAnimation { get; set; }


        public ICommand LoginCommand { get; set; }

        public SKLottieView TargetX { get; set; }

        private async Task ButtonClicked_Execute(object parameter)
        {
            if (parameter is Button loginbutton)
            {
                //LottieIsVisible = true;
                // Fügen Sie Ihre tatsächliche Login-Logik hier ein
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

    

