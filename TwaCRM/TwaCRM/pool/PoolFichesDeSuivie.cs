
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.mission;

namespace TwaCRM.pool{
    /**
     * La classe PoolFichesDeSuivie modélise la liste des factures
     */
    public class PoolFichesDeSuivie {

		/**
		 * Constructeur par défaut
		 */
		public PoolFichesDeSuivie() {
            FicheDeSuivies = new List<FicheDeSuivie>();
		}

		/**
		 * Contient la liste des fiches de suivie
		 */
		private List<FicheDeSuivie> _fichesDeSuivie;
        public List<FicheDeSuivie> FicheDeSuivies
        {
            get { return _fichesDeSuivie; }
            set { _fichesDeSuivie = value; }
        }


		/**
		 * @return la liste de toutes les fiches de suivie
		 */
        public List<FicheDeSuivie> getPool()
        {
			return FicheDeSuivies;
		}

	}
}