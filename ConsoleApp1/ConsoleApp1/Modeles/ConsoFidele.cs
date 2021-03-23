using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modeles
{
    class ConsoFidele : Conso
    {
        private int _dateDeNaissance;
        private int _pointFidelite;
        private DateTime _dateInscription;

        public ConsoFidele(int dateDeNaissance, int pointFidelite, DateTime dateInscription, string nom, string prenom, string mail, int tel) : base ( nom, prenom, mail, tel)
        {
            DateDeNaissance = dateDeNaissance;
            PointFidelite = pointFidelite;
            DateInscription = dateInscription;
        }

        public int DateDeNaissance { get => _dateDeNaissance; set => _dateDeNaissance = value; }
        public int PointFidelite { get => _pointFidelite; set => _pointFidelite = value; }
        public DateTime DateInscription { get => _dateInscription; set => _dateInscription = value; }
    }
}
