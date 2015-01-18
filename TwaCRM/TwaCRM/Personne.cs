
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM{
	/**
	 * La classe Personne modélise une personne simple
	 */
	public class Personne {

        /**
         * Constructeur par défaut
         */
        public Personne()
        {
        }

		/**
		 * Constructeur
		 */
        public Personne(String civilite, String nom, String prenom, String telephone)
		{
		    Civilite = civilite;
		    Nom = nom;
		    Prenom = prenom;
		    Telephone = telephone;
		}

        /**
         * Contient la civilité
         */
        private String _civilite;
        public String Civilite
        {
            get { return _civilite; }
            set { _civilite = value; }
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

        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return Civilite + " " + Prenom + " " + Nom + " | " + Telephone;
        }
	}
}