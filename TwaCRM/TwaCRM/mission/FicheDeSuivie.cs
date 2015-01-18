
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TwaCRM.mission{
	/**
	 * La classe FicheDeSuivie modélise une fiche de suivie associée à une mission
	 */
	public class FicheDeSuivie {
        
        /**
         * Constructeur par défaut
         */
        public FicheDeSuivie()
        {
        }

		/**
		 * Constructeur
		 */
		public FicheDeSuivie(Double avancement, Double risqueDeRetard, DateTime date)
        {
		    Avancement = avancement;
		    RisqueDeRetard = risqueDeRetard;
		    Date = date;
		}

		/**
		 * Contient le pourcentage d'avancement
		 */
        private Double _avancement;
        public Double Avancement
        {
            get { return _avancement; }
            set
            {
                // Vérifier si la valeur est bien un pourcentage
                if (value >= 0.0 && value <= 100.0) { _avancement = value; }
            }
        }

        /**
         * Contient le pourcentage de risque de retard
         */
        private Double _risqueDeRetard;
        public Double RisqueDeRetard
        {
            get { return _risqueDeRetard; }
            set
            {
                // Vérifier si la valeur est bien un pourcentage
                if (value >= 0.0 && value <= 100.0) { _risqueDeRetard = value; }
            }
        }

		/**
		 * Contient la date de soumission ou de mise à jour de la fiche de suivie
		 */
		private DateTime _date;
	    public DateTime Date
	    {
            get { return _date; }
            set { _date = value; }
	    }

        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return "Avancement : " + Avancement + "%" +
                " | Risque de retard : " + RisqueDeRetard + "%" +
                " | Soumis le : " + Date;
        }
	}
}