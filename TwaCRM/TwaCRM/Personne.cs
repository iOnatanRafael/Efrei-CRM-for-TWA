
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM{
	/**
	 * 
	 */
	public class Personne {

		/**
		 * Constructeur
		 */
		public Personne(String nom, String prenom, String telephone)
		{
		    Nom = nom;
		    Prenom = prenom;
		    Telephone = telephone;
		}

		/**
		 * Contient le nom de famille
		 */
		private String _nom;
	    public String Nom
	    {
            get { return _nom; }
            set { _nom = value; }
	    }

		/**
		 * 
		 */
        private String _prenom;
        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

		/**
		 * 
		 */
		private String _telephone;
	    public String Telephone
	    {
            get { return _telephone; }
            set { _telephone = value; }
	    }

	}
}