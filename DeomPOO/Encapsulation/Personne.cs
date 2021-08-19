using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO.Encapsulation
{
    public class Personne
    {
        // prop
        public string Nom { get; set; }

        // propfull
        private int _taille;
        public int Taille
        {
            get { return _taille; }
            set {
                if (value >= 0)
                    _taille = value;
            }
        }

        private DateTime _dateNaiss;
        public DateTime DateNaiss
        {
            get { return _dateNaiss; }
            set {
                if (value < DateTime.Today)
                    _dateNaiss = value;
            }
        }

        public Personne(string nom, int taille, DateTime dateNaiss)
        {
            Nom = nom;
            Taille = taille;
            DateNaiss = dateNaiss;
        }





    }
}
