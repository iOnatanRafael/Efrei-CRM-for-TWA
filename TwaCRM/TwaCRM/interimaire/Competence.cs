
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM.interimaire{
	/**
	 * La classe Competence mod�lise une comp�tence
	 */
	public class Competence {

        /**
         * Constructeur par d�faut
         */
        public Competence()
        {
        }

		/**
		 * Constructeur
		 */
		public Competence(String categorie, String nom)
		{
		    Categorie = categorie;
		    Nom = nom;
		}

		/**
		 * Contient la cat�gorie dans laquelle se range la comp�tence (ex.: Informatique)
		 */
		private String _categorie;
	    public String Categorie
	    {
            get { return _categorie; }
            set { _categorie = value; }
	    }

		/**
		 * Contient le nom de la comp�tence
		 */
        private String _nom;
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /**
         * Surcharge de l'op�rateur ToString
         */
        public override string ToString()
        {
            return "[" + Categorie + "] " + Nom;
        }
	}
}