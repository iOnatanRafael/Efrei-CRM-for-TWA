
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TwaCRM.entreprise;
using TwaCRM.interimaire;
using TwaCRM.mission;

namespace TwaCRM.pool{
	/**
	 * La classe PoolMissions modélise la liste des missions
	 */
	public class PoolMissions {

		/**
		 * Constructeur
		 */
		public PoolMissions() {
		}

		/**
		 * Contient la liste des missions
		 */
		private List<Mission> _missions;
        public List<Mission> Missions
	    {
            get { return _missions; }
            set { _missions = value; }
	    }

		/**
		 * @return
		 */
        public List<Mission> getPool()
        {
			return Missions;
		}

		/**
		 * @param Entreprise 
		 * @return
		 */
        public List<Mission> getPoolParEntreprise(Entreprise entreprise)
        {
			// TODO implement here
			return null;
		}

		/**
		 * @param EmployeInterim 
		 * @return
		 */
        public List<Mission> getPoolParEmployeInterim(EmployeInterim interimaire)
        {
			// TODO implement here
			return null;
		}

		/**
		 * @param tache 
		 * @return
		 */
        public List<Mission> chercherParTache(String tache)
        {
			// TODO implement here
			return null;
		}

		/**
		 * @param Date 
		 * @return
		 */
        public List<Mission> chercherParDateDebut(DateTime dateDebut)
        {
			// TODO implement here
			return null;
		}

		/**
		 * @param Date 
		 * @return
		 */
        public List<Mission> chercherParDateFin(DateTime dateFin)
        {
			// TODO implement here
			return null;
		}

		/**
		 * @param Mission 
		 * @return
		 */
		public bool ajouter(Mission mission) {
			// TODO implement here
            return false;
		}

	}
}