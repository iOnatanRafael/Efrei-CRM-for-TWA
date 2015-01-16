
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.pool;

namespace TwaCRM{
	/**
	 * La classe TwaCRM représente la classe principale
	 */
	public class TwaCRM {

		/**
		 * Constructeur
		 */
		public TwaCRM() {
		}

		/**
		 * Contient la liste des entreprises clientes
		 */
		private PoolEntreprisesClientes poolEntreprisesClientes;

		/**
		 * Contient la liste des intérimaires
		 */
		private PoolInterimaires poolInterimaires;

		/**
		 * Contient la liste des missions
		 */
		private PoolMissions poolMissions;

		/**
		 * Contient la liste des factures
		 */
		private PoolFactures poolFactures;

		/**
		 * Contient la liste des fiches de suivie
		 */
		private PoolFichesDeSuivie poolFichesDeSuivie;

	}
}