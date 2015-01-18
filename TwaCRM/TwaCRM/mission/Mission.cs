
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TwaCRM.entreprise;
using TwaCRM.interimaire;

namespace TwaCRM.mission{
	/**
	 * La classe Mission mod�lise une mission cr�ee par une entreprise et qui peut �tre attribu� � un int�rimaire
	 */
	public class Mission {
        
        /**
         * Constructeur par d�faut
         */
        public Mission()
        {
            _uniqueId = _counter;
            _counter++;
        }

		/**
		 * Constructeur
		 */
		public Mission(DateTime dateDebut, DateTime dateFin, String tache, Entreprise entreprise, EmployeInterim interimaire)
		{
            _uniqueId = _counter;
            _counter++;

		    DateDebut = dateDebut;
		    DateFin = dateFin;
		    Tache = tache;
		    Entreprise = entreprise;
		    EmployeInterim = interimaire;
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
		 * Contient la date de d�but de la mission
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
		 * Contient la t�che de la mission
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
		 * Contient l'int�rimaire de cette mission
		 */
        private EmployeInterim _employeInterim;
        public EmployeInterim EmployeInterim
        {
            get { return _employeInterim; }
            set { _employeInterim = value; }
        }

        /**
         * Surcharge de l'op�rateur ToString
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