using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO.ExoBanque
{
    class Courant
    {
        private double _solde;
        private double _ligneCredit;

        public string Numero { get; set; }
        public Personne Titulaire { get; set; }
        public double Solde
        {
            get { return _solde; }
            private set {
                if( value >= -LigneCredit )
                    _solde = value; 
            }
        }
        public double LigneCredit
        {
            get { return _ligneCredit; }
            set { 
                if( value >= 0 )
                    _ligneCredit = value; 
            }
        }

        public Courant(string numero, Personne titulaire, double ligneCredit)
        {
            Numero = numero;
            LigneCredit = ligneCredit;
            Titulaire = titulaire;
        }

        public void Retrait(double montant)
        {
            if( montant > 0 )
                Solde -= montant;
        }

        public void Depot(double montant)
        {
            if (montant > 0)
                Solde += montant;
        }


    }
}
