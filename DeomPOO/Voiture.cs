using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    class Voiture
    {

        public string marque = "VrimVroom";
        public string modele;
        public Moteur moteur;

        public Voiture() {}

        public Voiture(string modele, Moteur moteur)
        {
            this.modele = modele;
            this.moteur = moteur;
        }

        public Voiture(string marque, string modele, Moteur moteur)
        {
            this.marque = marque;
            this.modele = modele;
            this.moteur = moteur;
        }

        // signature : Voiture - afficherDetail - (bool)
        public void afficherDetail(bool avecDetail)
        {
            if (avecDetail)
            {
                afficherDetail();
            }
            else
            {
                Console.WriteLine("Voiture");
                Console.WriteLine("marque : " + this.marque);
                Console.WriteLine("modele : " + modele);
            }
        }

        // signature : Voiture - afficherDetail - (int)
        public void afficherDetail(int param)
        {
            Console.WriteLine("Troisième surcharge");
        }

        // signature Voiture - afficherDetail - ()
        public void afficherDetail()
        {
            Console.WriteLine("Voiture");
            Console.WriteLine("marque : " + this.marque);
            Console.WriteLine("modele : " + modele);
            Console.WriteLine("moteur(marque) : " + moteur.marque);
            Console.WriteLine("moteur(puissance) : " + moteur.puissance);
        }

    }
}
