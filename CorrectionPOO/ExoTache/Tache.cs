using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO.ExoTache
{

    public class Tache
    {
		private string _titre = "inconnu";
		private StatusTache _status;

		public string Titre
		{
			get { return _titre; }
			private set {
				if( value.Length <= 20 )
				_titre = value; 
			}
		}
		public string Description { get; set; }
		public StatusTache Status
		{
			get { return _status; }
			set { 
				if( _status < value )
					_status = value;
			}
		}

		public Tache(string titre) : this(titre, StatusTache.A_FAIRE)
		{}
		public Tache(string titre, StatusTache status)
		{
			Titre = titre;
			Status = status;
		}
		public Tache(string titre, string desc, StatusTache status)
		{
			Titre = titre;
			Description = desc;
			Status = status;
		}

		public bool Avancer()
		{
			if (Status == StatusTache.TERMINE)
				return true;

			Status++;

			return Status == StatusTache.TERMINE;
		}


	}
}
