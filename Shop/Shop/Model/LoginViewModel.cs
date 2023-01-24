using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using Shop.Model;
namespace Shop.Model
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string text;
        string showOutput;
        
        public Command LoginCommand { get;  }
        public Command RegCommand { get; }

        public Login MyLogin { get; set; }
        public string LoginText
        {
            get => text;
            set
            {
                text = value;
                var args = new PropertyChangedEventArgs(nameof(LoginText));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string ShowOutput
        {
            get => showOutput;
            set
            {
                showOutput = value;
                var args = new PropertyChangedEventArgs(nameof(ShowOutput));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(() =>
            {
                LoginText = MyLogin.Username + " " + MyLogin.Password;
            });
            MyLogin = new Login { Username = "", Password = "" };

            RegCommand = new Command(() =>
            {
                LoginText = " ";
            });
           
        }
    }
}
