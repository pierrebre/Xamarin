using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modeles
{
    class VenteMagasin : Vente
    {
        private string _matriculeVendeur;

        public VenteMagasin(string matriculeVendeur, DateTime dateVente, int montantVente, Conso leConso) : base ( dateVente,  montantVente,  leConso)
        {
            MatriculeVendeur = matriculeVendeur;
        }

        public string MatriculeVendeur { get => _matriculeVendeur; set => _matriculeVendeur = value; }
    }
}
