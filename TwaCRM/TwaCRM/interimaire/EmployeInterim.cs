
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TwaCRM.interimaire{
	/**
	 * La classe EmployeInterim mod�lise un int�rimaire
	 */
	public class EmployeInterim : Personne {
        
        /**
         * Constructeur par d�faut
         */
        public EmployeInterim()
        {
            _uniqueId = _counter;
            _counter++;
        }

		/**
		 * Constructeur
		 */
        public EmployeInterim(String civilite, String nom, String prenom, String telephone, List<Competence> competences, Double tarifJournalierFixe, Double tarifJournalierVariable)
            : base(civilite, nom, prenom, telephone)
        {
            _uniqueId = _counter;
            _counter++;

		    Competences = competences;
		    TarifJournalierFixe = tarifJournalierFixe;
		    TarifJournalierVariable = tarifJournalierVariable;
        }

        private static int _counter = 0;

        /**
         * Contient l'id unique
         */
        private int _uniqueId;
        public int UniqueId
        {
            get { return _uniqueId; }
            set { _uniqueId = value; }
        }

		/**
		 * Contient la liste des comp�tences de l'int�rimaire
		 */
		private List<Competence> _competences;
        public List<Competence> Competences
	    {
            get { return _competences; }
            set { _competences = value; }
	    }

		/**
		 * Contient le tarif journalier fixe de l'int�rimaire
		 */
		private Double _tarifJournalierFixe;
	    public Double TarifJournalierFixe
	    {
            get { return _tarifJournalierFixe; }
            set { _tarifJournalierFixe = value; }
	    }

		/**
		 * Contient le tarif journalier variable de l'int�rimaire (pourcentage)
		 */
        private Double _tarifJournalierVariable;
        public Double TarifJournalierVariable
        {
            get { return _tarifJournalierVariable; }
            set
            {
                // V�rifier si la valeur est bien un pourcentage
                if (value >= 0.0 && value <= 100.0) { _tarifJournalierVariable = value; }
            }
        }

		/**
		 * @param Competence 
		 * @return true si l'ajout a r�ussi, sinon false
		 */
		public bool ajouterCompetence(Competence competence)
        {
		    if (competence != null && competence.Categorie.Length > 0 && competence.Nom.Length > 0)
		    {
		        Competences.Add(competence);
		        return true;
		    }

		    return false;
        }

        /**
         * Surcharge de l'op�rateur ToString
         */
        public override string ToString()
        {
            return base.Civilite + " " + base.Prenom + " " + base.Nom + " | " + base.Telephone + " | Competences : " + Competences + " | Tarif journalier fixe : " + TarifJournalierFixe + " | Tarif journalier variable : " + TarifJournalierVariable;
        }

	}
}