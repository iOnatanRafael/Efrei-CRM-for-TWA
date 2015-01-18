
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TwaCRM.mission{
	/**
	 * La classe Facture modélise une facture associée à une mission d'une entreprise attribué à un intérimaire.
	 */
	public class Facture {
        
        /**
         * Constructeur par défaut
         */
        public Facture()
        {
            _uniqueId = _counter;
            _counter++;
        }

		/**
		 * Constructeur
		 */
		public Facture(int prixTotal)
        {
            _uniqueId = _counter;
            _counter++;

		    PrixTotal = prixTotal;
		}

        private static int _counter = 0;

        /**
         * Contient l'id unique
         */
        private int _uniqueId;

        [XmlAttribute("id")]
        public int UniqueId
        {
            get { return _uniqueId; }
            set { _uniqueId = value; }
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
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return "Prix total : " + PrixTotal;
        }
	}
}