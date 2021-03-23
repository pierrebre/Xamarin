using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Em.Modeles
{
    public class Evenement
    {
        public static ArrayList CollCLassEvenement = new ArrayList();

        private int _id;
        private string _nom;
        private DateTime _date;
        private string _genre;
        private string _description;

        public Evenement(int id, string nom, DateTime date, string genre, string description)
        {
            Id = id;
            Nom = nom;
            Date = date;
            Genre = genre;
            Description = description;
            Evenement.CollCLassEvenement.Add(this);
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
