using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using TestCarte.Modeles;
using Xamarin.Forms;

namespace TestCarte.VuesModeles
{
    class AjoutCarteVueModele : INotifyPropertyChanged
    {
        private ObservableCollection<CarteBus> _maListeCarte;

        private string _nomCarte;
        private string _prenomCarte;
        private int _numeroCarte;

        public AjoutCarteVueModele()
        {
            BtnAjoutCarte = new Command(AddToList);
        }


        public void AddToList()
        {
            
            CarteBus c1  = new CarteBus(NumeroCarte, NomCarte, PrenomCarte);
            MaListeCarte.Add(c1);
        }

        #region Getters / Setters
        internal ObservableCollection<CarteBus> MaListeCarte
        {
            get { return _maListeCarte; }
            set
            {
                _maListeCarte = value;
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

        public ICommand BtnAjoutCarte { get; }
        #endregion


        #region notifications
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
