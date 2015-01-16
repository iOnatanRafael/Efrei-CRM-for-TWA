
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM.entreprise{
	/**
	 * La classe Contact modélise un contact d'une entreprise
	 */
	public class Contact : Personne {

		/**
		 * Constructeur
		 */
        public Contact(String civilite, String nom, String prenom, String telephone, String role)
            : base(civilite, nom, prenom, telephone)
		{
		    Role = role;
		}

		/**
		 * Contient le rôle du contact dans son entreprise
		 */
		private String _role;
	    public String Role
	    {
            get { return _role; }
            set { _role = value; }
	    }

        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return base.Civilite + " " + base.Prenom + " " + base.Nom + " | " + Role + " | " + base.Telephone;
        }
	}
}