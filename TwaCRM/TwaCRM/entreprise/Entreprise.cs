
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM.entreprise{
	/**
	 * La classe Entreprise modélise une entreprise
	 */
	public class Entreprise {

		/**
		 * Constructeur
		 */
		public Entreprise(String nom, Adresse adresse, long siret, Contact contact)
		{
		    Nom = nom;
		    Adresse = adresse;
		    Siret = siret;
		    Contact = contact;
		}

		/**
		 * Contient le nom de l'entreprise
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
        private Adresse _adresse;
        public Adresse Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

		/**
		 * 
		 */
        private long _siret;
        public long Siret
        {
            get { return _siret; }
            set
            {
                // Vérifier si la longueur du numéro SIRET vaut bien 14
                if (value.ToString().Length == 14) { _siret = value; }
            }
        }

		/**
		 * 
		 */
        private Contact _contact;
        public Contact Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }



        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return Nom + " | Adresse : " + Adresse + " | No Siret : " + Siret + " | Contact : " + Contact;
        }

	}
}