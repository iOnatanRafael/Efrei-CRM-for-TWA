
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.mission;

namespace TwaCRM.pool{
    /**
     * La classe PoolFactures mod�lise la liste des factures
     */
    public class PoolFactures {

		/**
		 * Constructeur par d�faut
		 */
		public PoolFactures() {
            Factures = new List<Facture>();
		}

		/**
		 * Contient la liste des factures
		 */
        private List<Facture> _factures;
        public List<Facture> Factures
        {
            get { return _factures; }
            set { _factures = value; }
        }



		/**
		 * @return la liste de toutes les factures
		 */
        public List<Facture> getPool()
        {
			return Factures;
		}

	}
}