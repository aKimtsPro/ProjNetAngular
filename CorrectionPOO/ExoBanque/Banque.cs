using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO.ExoBanque
{
    class Banque
    {
        public string Nom { get; set; }
        private Dictionary<string, Courant> Comptes { get; set; }

        public Banque(string nom)
        {
            Nom = nom;
            Comptes = new Dictionary<string, Courant>();
        }

        public Courant this[string index]
        {
            get { // Courant nom_method( string index )
                //return Comptes[index];
                Comptes.TryGetValue(index, out Courant courant);
                return courant;
            }
        }

        public void Ajouter(Courant aAjouter)
        {
            if (!Comptes.ContainsKey(aAjouter.Numero))
                Comptes.Add( aAjouter.Numero, aAjouter );
        }

        public void Supprimer(string aSupprimer)
        {
            Comptes.Remove(aSupprimer);
        }

    }
}
