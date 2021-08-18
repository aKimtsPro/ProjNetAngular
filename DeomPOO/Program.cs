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

            Moteur m = new Moteur();
            m.marque = "vitesse";
            m.puissance = 100;

            Voiture v1 = new Voiture("BipBoop", "m-1", m);
            Voiture v2 = new Voiture("Trace", "m-2", m);

            m.puissance = 500;

            Console.ReadLine();
        }
    }
}
