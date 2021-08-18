using System;
using DemoEnum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStruct
{

    struct Localisation
    {
        public string longitude, latitude;
        public int altitude;
        public const int valeurMaxDegree = 360;
        public static string NOM_CONVENTION = "degree, minute, seconde";

        public void Afficher()
        {
            Console.WriteLine($"long : {longitude} | lat : {latitude} | alt: {altitude}");
        }


    }


    public class Program
    {
        static void Main(string[] args)
        {
            //Localisation l1 = null;
            Localisation localisation = new Localisation();
            localisation.longitude = "12°15'25\"";

            Localisation l2 = localisation;
            l2.longitude = "21°51'52\"";

            localisation.Afficher();
            l2.Afficher();
            //-----------
            Console.WriteLine("---------------------------");

            int a = 0;
            Incrementer(ref a);
            Console.WriteLine(a); // 1

            Afficher(false);
            Afficher();

            Console.WriteLine( Somme() );
            Console.WriteLine( Somme(15) );
            Console.WriteLine( Somme(18,19,0) );

            Console.ReadLine();
        }

        public static void Afficher(bool avecDetail = true)
        {
            Console.WriteLine("Affiche" + ( avecDetail ? " avec detail" : "" ));
        }

        public static void DemoIn(in int inVar)
        {
            Console.WriteLine(inVar);
            //inVar = 5;
        }

        public static void DemoOut(out int outVar)
        {
            // Console.WriteLine(outVar);
            outVar = 5;
        }

        public static void Incrementer(ref int aInc)
        {
            aInc++;
        }

        public static int Somme(int max = 0, params int[] entiers )
        {
            Console.WriteLine("maximum : " + max);
            int somme = 0;

            foreach (int entier in entiers)
            {
                somme += entier;
            }

            return somme;

            // Exo 2 slide 171 + Exo 1 slide 192
            // Bonus: Exo 2 slide 192
        }
    }
}
