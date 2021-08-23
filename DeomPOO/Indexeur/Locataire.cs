using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO.Indexeur
{
    class Locataire
    {

        public string Nom { get; set; }
        public DateTime DateNais { get; set; }

        public Locataire(string nom, DateTime dateNais)
        {
            Nom = nom;
            DateNais = dateNais;
        }

    }
}
