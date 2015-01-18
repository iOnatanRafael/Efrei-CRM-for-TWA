
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }

		/**
		 * Constructeur
		 */
		public Facture(Mission mission)
		{
		    Mission = mission;
		}

		/**
		 * Contient la mission concernée par la facture
		 */
		private Mission _mission;
	    public Mission Mission
	    {
            get { return _mission; }
            set { _mission = value; }
	    }

        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return Mission.ToString() +
                " | Tarif journalier fixe : " + Mission.EmployeInterim.TarifJournalierFixe +
                " | Tarif journalier variable : " + Mission.EmployeInterim.TarifJournalierVariable;
        }
	}
}