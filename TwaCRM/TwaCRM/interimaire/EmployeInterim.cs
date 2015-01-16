
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM.interimaire{
	/**
	 * 
	 */
	public class EmployeInterim : Personne {

		/**
		 * 
		 */
		public EmployeInterim(String nom, String prenom, String telephone) : base(nom, prenom, telephone) {
		}

		/**
		 * 
		 */
		private Competence[] competences;

		/**
		 * 
		 */
		private Double tarifJournalierFixe;

		/**
		 * 
		 */
		private Double tarifJournalierVariable;






		/**
		 * @param Competence 
		 * @return
		 */
		public void ajouterCompetence(Competence competence) {
			// TODO implement here
		}

	}
}