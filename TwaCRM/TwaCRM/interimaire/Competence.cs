
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM.interimaire{
	/**
	 * La classe Competence modélise une compétence
	 */
	public class Competence {

        /**
         * Constructeur par défaut
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
		 * Contient la catégorie dans laquelle se range la compétence (ex.: Informatique)
		 */
		private String _categorie;
	    public String Categorie
	    {
            get { return _categorie; }
            set { _categorie = value; }
	    }

		/**
		 * Contient le nom de la compétence
		 */
        private String _nom;
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return "[" + Categorie + "] " + Nom;
        }
	}
}