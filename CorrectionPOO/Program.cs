using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Personne p1 = new Personne("luc", new DateTime(1980, 1, 1), null);
            Personne p2 = new Personne("marie", new DateTime(1990,12,12), p1);
            p1.ami = p2;

            p1.QuestionnerAmi();
            p2.QuestionnerAmi();

            Console.ReadLine();

        }
    }
}
