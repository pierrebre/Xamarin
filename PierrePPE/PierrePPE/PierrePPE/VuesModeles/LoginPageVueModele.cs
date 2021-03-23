using PierrePPE.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PierrePPE.VuesModeles
{
    class LoginPageVueModele : INotifyPropertyChanged
    {
        private string _identifiant;
        private string _motDePasse;

        public LoginPageVueModele()
        {
            BoutonConnection = new Command(login);
        }

        public ICommand BoutonConnection { get; }
        public string Identifiant
        {
            get
            {
                return _identifiant;
            }
            set
            {
                if (_identifiant != value)
                {
                    _identifiant = value;
                    OnPropertyChanged(nameof(Identifiant));
                }
            }
        }
        public string MotDePasse
        {
            get
            {
                return _motDePasse;
            }
            set
            {
                if (_motDePasse != value)
                {
                    _motDePasse = value;
                    OnPropertyChanged(nameof(MotDePasse));
                }
            }
        }


        public void login()
        {   
            User user = new User(Identifiant, MotDePasse);
            if (user.CheckInformation())
            {
                Application.Current.MainPage.DisplayAlert("Login", "Login succes", "Ok");
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Login", "Mot de passe ou Identifiant incorrect", "Ok");
            }
        }


        #region notifications
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
