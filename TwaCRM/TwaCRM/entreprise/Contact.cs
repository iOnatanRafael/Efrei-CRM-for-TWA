
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM.entreprise{
	/**
	 * 
	 */
	public class Contact : Personne {

		/**
		 * Constructeur
		 */
		public Contact(String nom, String prenom, String telephone, String role) : base(nom, prenom, telephone)
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

	}
}