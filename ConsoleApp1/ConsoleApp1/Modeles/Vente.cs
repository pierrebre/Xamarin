using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modeles
{
    class Vente
    {
        private DateTime _dateVente;
        private int _montantVente;
        private Conso leConso;

        public DateTime DateVente { get => _dateVente; set => _dateVente = value; }
        public int MontantVente { get => _montantVente; set => _montantVente = value; }
        internal Conso LeConso { get => leConso; set => leConso = value; }

        public Vente(DateTime dateVente, int montantVente, Conso leConso)
        {
            DateVente = dateVente;
            MontantVente = montantVente;
            LeConso = leConso;
        }
    }
}
