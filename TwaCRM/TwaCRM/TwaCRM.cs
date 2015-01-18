
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

            //this.firstInitPoolEntreprisesClientes();
            PoolEntreprisesClientes.chargerXml(@"PoolEntreprisesClientes.xml");

            foreach (var entreprise in PoolEntreprisesClientes.getPool())
		    {
		        Console.WriteLine(entreprise);
		    }
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



        /**
         * La méthode firstInitPoolEntreprises permet de créer 10 entreprises
         */
        public void firstInitPoolEntreprisesClientes()
        {
            PoolEntreprisesClientes.ajouter(
                new Entreprise("Baidu",
                    new Adresse("60", "avenue de la République", "75007", "Paris", "France"),
                    79900069000013,
                    new Contact("M", "Xiao", "Mi", "0638589828", "DRH")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("Microsoft",
                    new Adresse("24", "rue de la Liberté", "94800", "Villejuif", "France"),
                    50850302600017,
                    new Contact("M", "Killian", "Herbunot", "0612131465", "PDG")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("MK Import & Co",
                    new Adresse("1-2", "boulevard du Général de Gaulle", "59100", "Roubaix", "France"),
                    48956423400016,
                    new Contact("M", "Dimitri", "Mbairobe", "0791375462", "DRH")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("Confocuisine",
                    new Adresse("2", "Avenue des Ducs de Savoie", "73000", "Chambery", "France"),
                    31643141000034,
                    new Contact("M", "Jean-Luc", "Mélenchon", "0716542365", "Gérant")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("CPW Labs",
                    new Adresse("88", "boulevard de Verratti", "75016", "Paris", "France"),
                    75202345700019,
                    new Contact("M", "William", "Zhong", "0688582838", "PDG")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("Vougy",
                    new Adresse("39", "Domaine des Cedres", "69390", "Vernaison", "France"),
                    44483571400015,
                    new Contact("M", "Cédric", "Caillou", "0645454565", "PDG")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("ABC Douceur",
                    new Adresse("3", "Place Nicole Neuburger", "93140", "Bondy", "France"),
                    51426412600012,
                    new Contact("M", "Sarah", "Kroche", "0798653212", "RH")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("Vougy",
                    new Adresse("39", "Domaine des Cedres", "69390", "Vernaison", "France"),
                    44483571400015,
                    new Contact("M", "Cédric", "Caillou", "0715632654", "RH")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("Marcel SARL",
                    new Adresse("2", "Allée des Erables", "95360", "Montmagny", "France"),
                    44802963700023,
                    new Contact("M", "Marcel", "Desailly", "0687898512", "Gérant")
                    )
                );

            PoolEntreprisesClientes.ajouter(
                new Entreprise("Zlataneur SA",
                    new Adresse("10", "Domaine d'Ibrahimovic", "75016", "Paris", "France"),
                    52316479600014,
                    new Contact("M", "Zlatan", "Ibrahimovic", "0828663663", "Dieu")
                    )
                );
        }
	}
}