
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TwaCRM.interimaire{
	/**
	 * La classe EmployeInterim modélise un intérimaire
	 */
	public class EmployeInterim : Personne {

		/**
		 * Constructeur
		 */
        public EmployeInterim(String civilite, String nom, String prenom, String telephone, DataTable competences, Double tarifJournalierFixe, Double tarifJournalierVariable)
            : base(civilite, nom, prenom, telephone)
		{
		    Competences = competences;
		    TarifJournalierFixe = tarifJournalierFixe;
		    TarifJournalierVariable = tarifJournalierVariable;
		}

		/**
		 * Contient la liste des compétences de l'intérimaire
		 */
		private DataTable _competences;
	    public DataTable Competences
	    {
            get { return _competences; }
            set { _competences = value; }
	    }

		/**
		 * Contient le tarif journalier fixe de l'intérimaire
		 */
		private Double _tarifJournalierFixe;
	    public Double TarifJournalierFixe
	    {
            get { return _tarifJournalierFixe; }
            set { _tarifJournalierFixe = value; }
	    }

		/**
		 * Contient le tarif journalier variable de l'intérimaire (pourcentage)
		 */
        private Double _tarifJournalierVariable;
        public Double TarifJournalierVariable
        {
            get { return _tarifJournalierVariable; }
            set
            {
                // Vérifier si la valeur est bien un pourcentage
                if (value >= 0.0 && value <= 100.0) { _tarifJournalierVariable = value; }
            }
        }






		/**
		 * @param Competence 
		 * @return
		 */
		public void ajouterCompetence(Competence competence) {
			// TODO implement here
		}

        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return base.Civilite + " " + base.Prenom + " " + base.Nom + " | " + base.Telephone + " | Competences : " + Competences + " | Tarif journalier fixe : " + TarifJournalierFixe + " | Tarif journalier variable : " + TarifJournalierVariable;
        }

	}
}