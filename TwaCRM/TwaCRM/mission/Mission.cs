
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.entreprise;
using TwaCRM.interimaire;

namespace TwaCRM.mission{
	/**
	 * La classe Mission modélise une mission créee par une entreprise et qui peut être attribué à un intérimaire
	 */
	public class Mission {

		/**
		 * Constructeur
		 */
		public Mission(DateTime dateDebut, DateTime dateFin, String tache, Entreprise entreprise, EmployeInterim interimaire)
		{
		    DateDebut = dateDebut;
		    DateFin = dateFin;
		    Tache = tache;
		    Entreprise = entreprise;
		    EmployeInterim = interimaire;
		}

		/**
		 * Contient la date de début de la mission
		 */
		private DateTime _dateDebut;
	    public DateTime DateDebut
	    {
            get { return _dateDebut; }
            set { _dateDebut = value; }
	    }

        /**
         * Contient la date de fin de la mission
         */
        private DateTime _dateFin;
        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

		/**
		 * Contient la tâche de la mission
		 */
        private String _tache;
        public String Tache
        {
            get { return _tache; }
            set { _tache = value; }
        }

		/**
		 * Contient l'entreprise responsable de cette mission
		 */
        private Entreprise _entreprise;
        public Entreprise Entreprise
        {
            get { return _entreprise; }
            set { _entreprise = value; }
        }

		/**
		 * Contient l'intérimaire de cette mission
		 */
        private EmployeInterim _employeInterim;
        public EmployeInterim EmployeInterim
        {
            get { return _employeInterim; }
            set { _employeInterim = value; }
        }


        /**
         * Surcharge de l'opérateur ToString
         */
        public override string ToString()
        {
            return "Entreprise : " + Entreprise.Nom + 
                " | Interimaire : " + EmployeInterim.Civilite + " " + EmployeInterim.Prenom + " " + EmployeInterim.Nom +
                " | Tache : " + Tache +
                " | Debut : " + DateDebut +
                " | Fin : " + DateFin;
        }
	}
}