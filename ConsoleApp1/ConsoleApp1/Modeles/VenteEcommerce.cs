using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modeles
{
    class VenteEcommerce : Vente
    {
        private string _adresseLivraison;
        private string _optionLivraison;
        
        public VenteEcommerce(string adresseLivraison, string optionLivraison, DateTime dateVente, int montantVente, Conso leConso) : base (dateVente, montantVente, leConso)
        {
            _adresseLivraison = adresseLivraison;
            _optionLivraison = optionLivraison;
        }
    }
}
