
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TwaCRM.mission{
	/**
	 * La classe Facture mod�lise une facture associ�e � une mission d'une entreprise attribu� � un int�rimaire.
	 */
	public class Facture {
        
        /**
         * Constructeur par d�faut
         */
        public Facture()
        {
        }

		/**
		 * Constructeur
		 */
		public Facture(int prixTotal)
        {
            PrixTotal = prixTotal;
		}

		/**
		 * Contient le prix total de la facture
		 */
		private int _prixTotal;
        public int PrixTotal
	    {
            get { return _prixTotal; }
            set { _prixTotal = value; }
	    }

        /**
         * Surcharge de l'op�rateur ToString
         */
        public override string ToString()
        {
            return "Prix total : " + PrixTotal;
        }
	}
}