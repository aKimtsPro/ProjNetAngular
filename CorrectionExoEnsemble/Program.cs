using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoEnsemble
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crée un algorithme permetant de récupérer sous la forme d'une collection
            // optimisation:
            //  - il n'est pas nécessaire de vérifier si un nombre est divisible par un autre non premier
            //  - il n'est pas nécessaire de vérifier si un nombre est divisible par un autre supérieur à sa moitié


            // Récupération du nombre de premiers souhaité.
            Console.WriteLine("Veuillez entrer le nombre de premiers à récupérer");
            bool success = int.TryParse( Console.ReadLine(), out int nbrPrimes );
            if (!success || nbrPrimes < 0)
                return;


            // On sait le nombre d'élément souhaité mais on veut être au courant du nombre de premier
            // trouvé => choix de la liste car Count me donnera cette info alors que le Lenght d'un
            // tableau créé à nbrPrimes cases me donnera le nombre de premiers souhaités.
            List<int> primes = new List<int>();


            // pour chaque nombre(candidat) supérieur ou égal à 2
            // et tant qu'on a pas atteint le nombre de premiers requis
            for(int candidat=2; primes.Count < nbrPrimes; candidat++)
            {
                if ( IsPremier(candidat, primes) )
                    primes.Add(candidat);
            }

            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }

            Console.ReadLine();

        }

        public static bool IsPremier(int candidat, List<int> primes)
        {
            if (candidat < 2)
                return false;

            // on verifie si le candidat est premier
            bool isPrime = true;

            // on vérifie si le candidat est divisible seulement par les nombres premiers trouvés
            // inférieur à la moitité du candidat. Dès qu'on trouve un diviseur, on sait que le
            // candidat n'est pas premier.
            for (int index = 0; index < primes.Count && primes[index] <= candidat / 2 && isPrime; index++)
            {
                if (candidat % primes[index] == 0)
                    isPrime = false;
            }

            // si il est premier on l'ajoute
            return isPrime;
        } 
    }
}
