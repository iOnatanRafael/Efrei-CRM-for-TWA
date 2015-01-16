
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.entreprise;

namespace TwaCRM.pool{
	/**
	 * La classe PoolEntreprisesClientes modélise la liste des entreprises clientes
	 */
	public class PoolEntreprisesClientes {

		/**
		 * Constructeur
		 */
		public PoolEntreprisesClientes() {
            EntreprisesClientes = new List<Entreprise>();
		}

		/**
		 * Contient la liste des entreprises clientes
		 */
        private List<Entreprise> _entreprisesClientes;
	    public List<Entreprise> EntreprisesClientes
	    {
            get { return _entreprisesClientes; }
            set { _entreprisesClientes = value; }
	    }



		/**
		 * @return la liste des entreprises clientes
		 */
        public List<Entreprise> getPool()
        {
			return EntreprisesClientes;
		}

		/**
		 * @param nom 
		 * @return la liste des entreprises portant le nom "nom"
		 */
        public List<Entreprise> chercher(string nom)
        {
			// TODO implement here
			return null;
		}

        /**
         * @param Entreprise 
         * @return true si l'ajout a réussi, sinon false
         */
        public bool ajouter(Entreprise entreprise)
        {
            if (entreprise != null)
            {
                EntreprisesClientes.Add(entreprise);
                return true;
            }

            return false;
		}

		/**
		 * @param nom 
		 * @return true si la suppression a réussi, sinon false
		 */
		public bool supprimer(string nom) {
			// TODO implement here
            return false;
		}

	}
}