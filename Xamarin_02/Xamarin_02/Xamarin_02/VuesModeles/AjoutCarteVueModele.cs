using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_02.Menu;

namespace Xamarin_02.VuesModeles
{
    public class AjoutCarteVueModele : INotifyPropertyChanged
    {
        public static ArrayList laListeCarte = new ArrayList();
        private ObservableCollection<CarteBus> _listViewCarte;
        private int _numeroCarte; // Binding Entry XAML
        private string _nomCarte; // Binding Entry XAML
        private string _prenomCarte;  // Binding Entry XAML
        public CarteBus uneCarte;
        public string _test;

        public AjoutCarteVueModele()
        {
           BtnAjouterCarte = new Command(InstansciationCarte);
            
        }

        public ICommand BtnAjouterCarte { get; }
        public int NumeroCarte
        {
            get
            {
                return _numeroCarte;
            }
            set
            {
                if (_numeroCarte != value)
                {
                    _numeroCarte = value;
                    OnPropertyChanged(nameof(NumeroCarte));
                }
            }
        }
        public string NomCarte
        {
            get
            {
                return _nomCarte;
            }
            set
            {
                if (_nomCarte != value)
                {
                    _nomCarte = value;
                    OnPropertyChanged(nameof(NomCarte));
                }
            }
        }
        public string PrenomCarte
        {
            get
            {
                return _prenomCarte;
            }
            set
            {
                if (_prenomCarte != value)
                {
                    _prenomCarte = value;
                    OnPropertyChanged(nameof(PrenomCarte));
                }
            }
        }

        public string Test
        {
            get
            {
                return _test;
            }
            set
            {
                if (_test != value)
                {
                    _test = value;
                    OnPropertyChanged(nameof(Test));
                }
            }
        }

        public ObservableCollection<CarteBus> ListViewCarte 
        {
            get
            {
                return _listViewCarte;
            }
            set
            {
                _listViewCarte = value;
                OnPropertyChanged();
            }
        }

        public void InstansciationCarte()
        {
            CarteBus c1 = new CarteBus(NumeroCarte, NomCarte, PrenomCarte);
            laListeCarte.Add(c1);
            Test.


        }

        public async void popUp()
        {
            await Application.Current.MainPage.DisplayAlert("Login", "Mot de passe ou Identifiant incorrect", "Ok");
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
