using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_02.Menu;
using Xamarin_02.Vues;

namespace Xamarin_02.VuesModeles
{
    class CarteVueModele
    {
        private int _numeroCarte;
        private string _nomCarte;
        private string _prenomCarte;
        public CarteBus uneCarte;

        public CarteVueModele()
        {
            BtnAjout = new Command(AjoutCarte);
            
        }
        public ICommand BtnAjout { get; }
        public int NumeroCarte { get => _numeroCarte; set => _numeroCarte = value; }
        public string NomCarte { get => _nomCarte; set => _nomCarte = value; }
        public string PrenomCarte { get => _prenomCarte; set => _prenomCarte = value; }

        public void AjoutCarte()
        {
            Application.Current.MainPage = (new AjoutCartePage());
        }

        
       
    }
}
