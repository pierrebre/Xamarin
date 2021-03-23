using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestCarte.Modeles
{
    class CarteBus
    {
        public static ArrayList CollClassCarteBus = new ArrayList();

        private int _numeroCarte;
        private string _nom;
        private string _prenom;

        public CarteBus(int numeroCarte, string nom, string prenom)
        {
            NumeroCarte = numeroCarte;
            Nom = nom;
            Prenom = prenom;
            CarteBus.CollClassCarteBus.Add(this);
        }

        public int NumeroCarte { get => _numeroCarte; set => _numeroCarte = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
    }
}
