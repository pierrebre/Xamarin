using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modeles
{
    public class Conso
    {
        public static ArrayList CollClassConso = new ArrayList();
        protected static ArrayList LesVentes;

        private string nom;
        private string prenom;
        private string mail;
        private int tel;

        public Conso(string nom, string prenom, string mail, int tel)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Mail = mail;
            this.Tel = tel;
            LesVentes = new ArrayList();
            Conso.CollClassConso.Add(this);
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Tel { get => tel; set => tel = value; }

        private bool estfidele()
        {
            bool resultat = true;
            return resultat;
        }

        public int GetNbVentes()
        {
            int resultat = 0;
            foreach (Vente uneVente in LesVentes)
            {
                if ()
                {

                }
            }
            return resultat;
        }

    }
}
