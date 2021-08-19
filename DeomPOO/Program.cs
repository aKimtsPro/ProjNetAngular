using DemoPOO.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Moteur m = new Moteur();
            //m.marque = "vitesse";
            //m.puissance = 100;

            //Voiture v1 = new Voiture("BipBoop", "m-1", m);
            //Voiture v2 = new Voiture("Trace", "m-2", m);

            //m.puissance = 500;

            //DateTime date = new DateTime(1999,9,9);

            //TimeSpan ts = DateTime.Today - new DateTime(1999,9,9);
            //long nbrAnnée = ts.Days / 365;
            //Console.WriteLine(nbrAnnée);

            // Encapsulation

            Personne p1 = new Personne("luc", 180, DateTime.Today - TimeSpan.FromDays(5));
            p1.Taille = -180;
            Console.WriteLine( p1.Taille ); // 180

            Livre l = new Livre("le livre", "l'auteur", 1800, 500);

            Console.WriteLine("Livre");
            Console.WriteLine("nom : " + l.Nom); 
            Console.WriteLine("auteur : " + l.NomAuteur);
            Console.WriteLine("nombre de page : " + l.NbrPage);
            Console.WriteLine("marque page : " + l.MarquePage);

            l.NbrPage = 5;

            Console.ReadLine();
        }
    }
}
