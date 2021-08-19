﻿using C = CorrectionPOO.ExoClass;
using CorrectionPOO.ExoBanque;
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
            // Exo Classe
            //C.Personne p1 = new C.Personne("luc", new DateTime(1980, 1, 1), null);
            //C.Personne p2 = new C.Personne("marie", new DateTime(1990,12,12), p1);
            //p1.ami = p2;

            //p1.QuestionnerAmi();
            //p2.QuestionnerAmi();

            // ExoBanque
            Personne p = new Personne("luc", "luc", DateTime.Now);
            Courant c = new Courant("1", p, 100);
            // solde : 0 | ligne : 100
            Console.WriteLine($"Solde : { c.Solde } | Ligne : { c.LigneCredit } ");
            c.Depot(-50);
            Console.WriteLine($"Solde : { c.Solde } | Ligne : { c.LigneCredit } ");

            Console.ReadLine();

        }
    }
}
