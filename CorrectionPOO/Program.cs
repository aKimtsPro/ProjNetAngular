using C = CorrectionPOO.ExoClass;
using CorrectionPOO.ExoBanque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectionPOO.ExoTache;

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
            //Personne p = new Personne("luc", "luc", DateTime.Now);
            //Courant c = new Courant("1", p, 100);
            //// solde : 0 | ligne : 100
            //Console.WriteLine($"Solde : { c.Solde } | Ligne : { c.LigneCredit } ");
            //c.Depot(-50);
            //Console.WriteLine($"Solde : { c.Solde } | Ligne : { c.LigneCredit } ");


            // ExoTache

            //Tache t = new Tache("faire les courses");

            //t.Status = StatusTache.EN_PREPARATION;
            //Console.WriteLine(t.Status);

            //t.Status = StatusTache.EN_COURS;
            //Console.WriteLine(t.Status);

            //t.Status = StatusTache.EN_PREPARATION;
            //Console.WriteLine(t.Status);

            //Console.WriteLine( t.Avancer() );
            //Console.WriteLine( t.Status );

            // ExoBanque - part 2

            Banque banque = new Banque("big mony");

            banque.Ajouter(new Courant("1", new Personne("luc", null, DateTime.Now), 0));
            banque.Ajouter(new Courant("1", new Personne("lucie", null, DateTime.Now), 0));
            banque.Ajouter(new Courant("2", new Personne("marie", null, DateTime.Now), 10));
            banque.Ajouter(new Courant("3", new Personne("dominique", null, DateTime.Now), 200));
            banque.Ajouter(new Courant("4", new Personne("sami", null, DateTime.Now), 3000));

            Console.WriteLine(banque["1"].Titulaire.Nom );

            Console.ReadLine();
        }
    }
}
