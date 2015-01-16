
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.entreprise;
using TwaCRM.interimaire;
using TwaCRM.mission;

namespace TwaCRM.pool{
	/**
	 * 
	 */
	public class PoolMissions {

		/**
		 * 
		 */
		public PoolMissions() {
		}

		/**
		 * 
		 */
		private Mission[] missions;





		/**
		 * @return
		 */
		public Mission[] getPool() {
			// TODO implement here
			return null;
		}

		/**
		 * @param Entreprise 
		 * @return
		 */
		public Mission[] getPoolParEntreprise(Entreprise entreprise) {
			// TODO implement here
			return null;
		}

		/**
		 * @param EmployeInterim 
		 * @return
		 */
		public Mission[] getPoolParEmployeInterim(EmployeInterim interimaire) {
			// TODO implement here
			return null;
		}

		/**
		 * @param tache 
		 * @return
		 */
		public Mission[] chercherParTache(String tache) {
			// TODO implement here
			return null;
		}

		/**
		 * @param Date 
		 * @return
		 */
		public Mission[] chercherParDateDebut(DateTime dateDebut) {
			// TODO implement here
			return null;
		}

		/**
		 * @param Date 
		 * @return
		 */
		public Mission[] chercherParDateFin(DateTime dateFin) {
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