using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnum
{
    struct Transaction
    {
        public decimal montant;
        private Monnaie monnaie;
    }


    enum Monnaie
    {
        USD,
        EUR,
        CAD
    }

    public enum Couleur
    {
        ROUGE,
        BLEU = -1,
        VERT,
        JAUNE = 5,
        ORANGE
    }

    class Program
    {
        static void Main(string[] args)
        {
            Couleur c = Couleur.ROUGE;
            Couleur c1 = Couleur.ORANGE;

            Console.WriteLine( c == c1 ); // 

            //Couleur c = 0; // possible
            //Couleur c = 19; // impossible (le nombre doit être représenté dans l'enum) 
            Console.WriteLine( c );
            string[] nomDesValeurs = Enum.GetNames( typeof(Couleur) );
            Array tabCoul = Enum.GetValues(typeof(Couleur));
            IEnumerator e = tabCoul.GetEnumerator();
            while( e.MoveNext() )
            {
                Console.WriteLine(e.Current);
            }

            string rouge = "ROUGE";

            c = (Couleur)Enum.Parse(typeof(Couleur), rouge);

            Console.ReadLine();

        }
    }
}
