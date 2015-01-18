
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
            _uniqueId = _counter;
            _counter++;
        }

		/**
		 * Constructeur
		 */
		public FicheDeSuivie(Mission mission, Double avancement, Double risqueDeRetard, DateTime date)
        {
            _uniqueId = _counter;
            _counter++;

		    Mission = mission;
		    Avancement = avancement;
		    RisqueDeRetard = risqueDeRetard;
		    Date = date;
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
		 * Contient la mission concernée par la fiche de suivie
		 */
		private Mission _mission;
	    public Mission Mission
	    {
            get { return _mission; }
            set { _mission = value; }
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
            return "Mission : " + Mission.Tache +
                " | Entreprise : " + Mission.Entreprise.Nom +
                " | Interimaire : " + Mission.EmployeInterim.Civilite + " " + Mission.EmployeInterim.Prenom + " " + Mission.EmployeInterim.Nom +
                " | Avancement : " + Avancement + "%" +
                " | Risque de retard : " + RisqueDeRetard + "%" +
                " | Soumis le : " + Date;
        }
	}
}