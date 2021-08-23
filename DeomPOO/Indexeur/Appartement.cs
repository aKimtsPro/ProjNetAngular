﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO.Indexeur
{
    class Appartement
    {

        public List<Proprietaire> Proprietaires { get; set; }
        // associe un locataire à l'argent qu'il paie en loyer
        private Dictionary<Locataire, int> Locataires { get; set; }

        public Appartement()
        {
            Proprietaires = new List<Proprietaire>();
            Locataires = new Dictionary<Locataire, int>();
        }


        public int this[ Locataire key ]
        {
            get
            {
                if (Locataires.ContainsKey(key))
                    return Locataires[key];

                return 0;
            }
            set
            {
                if (Locataires.ContainsKey(key))
                {
                    Locataires[key] = value;
                }
            }
        }
       
        // Obtenir le loyer d'un locataire a partir de l'appartement
        // Si le locataire n'est pas dans cet appart, => 0
        public int GetLoyerOf( Locataire locataire )
        {
            if( Locataires.ContainsKey(locataire) )
                return Locataires[locataire];

            return 0;
        }

        // Modifie le loyer d'un locataire si il existe
        public void SetLoyerOf( Locataire locataire, int newLoyer)
        {
            if( Locataires.ContainsKey(locataire) )
            {
                Locataires[locataire] = newLoyer;
            }
        }


        public void Add(Locataire locataire, int loyer)
        {
            Locataires.Add(locataire, loyer);
        }
    }
}
