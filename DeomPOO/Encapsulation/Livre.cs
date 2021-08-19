using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO.Encapsulation
{
    class Livre
    {
        // prop
        public string Nom { get; private set; }
        public string NomAuteur { get; private set; }
        // propfull
        private int _nbrPage;
        public int NbrPage
        {
            get { return _nbrPage; }
            private set { 
                if(value >= 100 && value <= 1000)
                    _nbrPage = value; 
            }
        }
        private int _marquePage;
        public int MarquePage
        {
            get { return _marquePage; }
            set { 
                if( value >= 1 && value <= NbrPage)
                    _marquePage = value; 
            }
        }

        public Livre( string titre, string auteur, int nbrPage, int marquePage)
        {
            Nom = titre;
            NomAuteur = auteur;
            NbrPage = nbrPage;
            MarquePage = marquePage;
        }



    }
}
