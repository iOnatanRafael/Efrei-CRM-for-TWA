
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.entreprise;
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
            PoolEntreprisesClientes = new PoolEntreprisesClientes();

            Console.WriteLine("[DEBUT] Liste des entreprises clientes");
            Console.WriteLine(PoolEntreprisesClientes.EntreprisesClientes.Count);
		    Console.WriteLine("Ajout d'une entreprise");
		    PoolEntreprisesClientes.ajouter(
		        new Entreprise("Microsoft",
		            new Adresse("24", "rue Henri Luisette", "94800", "Villejuif", "France"),
		            12345678912345,
		            new Contact("M", "Zhong", "William", "0631618620", "PDG")
		            )
                );
            Console.WriteLine(PoolEntreprisesClientes.EntreprisesClientes[0]);
            Console.WriteLine("[FIN] Liste des entreprises clientes");
		}

		/**
		 * Contient la liste des entreprises clientes
		 */
		private PoolEntreprisesClientes _poolEntreprisesClientes;
	    public PoolEntreprisesClientes PoolEntreprisesClientes
	    {
            get { return _poolEntreprisesClientes; }
            set { _poolEntreprisesClientes = value; }
	    }

		/**
		 * Contient la liste des intérimaires
		 */
        private PoolInterimaires _poolInterimaires;
        public PoolInterimaires PoolInterimaires
        {
            get { return _poolInterimaires; }
            set { _poolInterimaires = value; }
        }

		/**
		 * Contient la liste des missions
		 */
        private PoolMissions _poolMissions;
        public PoolMissions PoolMissions
        {
            get { return _poolMissions; }
            set { _poolMissions = value; }
        }

		/**
		 * Contient la liste des factures
		 */
        private PoolFactures _poolFactures;
        public PoolFactures PoolFactures
        {
            get { return _poolFactures; }
            set { _poolFactures = value; }
        }

		/**
		 * Contient la liste des fiches de suivie
		 */
        private PoolFichesDeSuivie _poolFichesDeSuivie;
        public PoolFichesDeSuivie PoolFichesDeSuivie
        {
            get { return _poolFichesDeSuivie; }
            set { _poolFichesDeSuivie = value; }
        }

	}
}