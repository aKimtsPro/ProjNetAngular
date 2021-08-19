using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO.ExoClass
{
    class Personne
    {
        public string nom;
        public DateTime dateNaiss;
        public Personne ami;

        public Personne(string nom, DateTime dateNaiss, Personne ami)
        {
            this.nom = nom;
            this.dateNaiss = dateNaiss;
            this.ami = ami;
        }

        public void QuestionnerAmi()
        {
            Console.WriteLine($"{nom} - Bonjour {ami.nom} quel age as-tu?");
            ami.Repondre(this);
        }

        public void Repondre(Personne questionneur)
        {
            TimeSpan ts = DateTime.Today - dateNaiss;
            int age = DateTime.Today.Year - dateNaiss.Year;
            //int age = (DateTime.Today - dateNaiss).Days / 365;
            //int age = new DateTime(DateTime.Now.Subtract(dateNaiss).Ticks).Year - 1; 
            Console.WriteLine($"{nom} - Oh salut {questionneur.nom} j'ai {age} ans.");
        }
    }
}
