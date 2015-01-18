
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwaCRM.entreprise;
using TwaCRM.interimaire;
using TwaCRM.mission;
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
            PoolInterimaires = new PoolInterimaires();
            PoolMissions = new PoolMissions();

            PoolEntreprisesClientes.chargerXml(@"PoolEntreprisesClientes.xml");
            PoolInterimaires.chargerXml(@"PoolInterimaires.xml");
            PoolMissions.chargerXml(@"PoolMissions.xml");

		    int cpt = 0;
            foreach (Mission mission in PoolMissions.getPool())
		    {
                Console.WriteLine(cpt.ToString() + ". " + mission);
		        cpt++;
		    }

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
         * La méthode firstInit permet de peupler la base de données de l'application
         */
        public void firstInit()
	    {
	        firstInitPoolEntreprisesClientes(@"PoolEntreprisesClientes.xml");
            firstInitPoolInterimaires(@"PoolInterimaires.xml");
            firstInitPoolMissions(@"PoolMissions.xml");
	    }

        /**
         * La méthode firstInitPoolEntreprises permet de créer 10 entreprises
         */
        public void firstInitPoolEntreprisesClientes(String nomFichier)
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

            PoolEntreprisesClientes.sauvegarderXml(nomFichier);
        }

        /**
         * La méthode firstInitPoolInterimaires permet de créer 15 intérimaires
         */
        public void firstInitPoolInterimaires(String nomFichier)
        {
            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Atsuda",
                    "Konaté",
                    "0636489658",
                    new List<Competence>()
                    {
                        new Competence("Informatique", "C#"),
                        new Competence("Cuisine", "Japonaise")
                    },
                    25.0,
                    0.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Aubameyang",
                    "Pierre-Emerick",
                    "0625153565",
                    new List<Competence>()
                    {
                        new Competence("Sport", "Football"),
                        new Competence("Sport", "Athletisme"),
                        new Competence("Coiffure", "Tendance")
                    },
                    0.0,
                    2.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Sarkozy",
                    "Nicolas",
                    "0825653515",
                    new List<Competence>()
                    {
                        new Competence("Politique", "Convaincre"),
                        new Competence("Sport", "Jogging"),
                        new Competence("Communication", "Gesture")
                    },
                    0.0,
                    80.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Jacob",
                    "Pierre",
                    "0798562312",
                    new List<Competence>()
                    {
                        new Competence("Bureautique", "Microsoft Word")
                    },
                    0.0,
                    0.05
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("Mme",
                    "Kardashian",
                    "Kim",
                    "0878985868",
                    new List<Competence>(),
                    0.0,
                    50.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("Mlle",
                    "Frantz",
                    "Vanessa",
                    "0626366898",
                    new List<Competence>()
                    {
                        new Competence("Photographie", "Selfie"),
                        new Competence("Photographie", "Mirroir")
                    },
                    10.0,
                    0.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Big Ali",
                    "Amine",
                    "0645555636",
                    new List<Competence>()
                    {
                        new Competence("Musique", "Rap"),
                        new Competence("Marketing", "Bling bling")
                    },
                    0.0,
                    25.5
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Jobs",
                    "Steve",
                    "0858484848",
                    new List<Competence>()
                    {
                        new Competence("Général", "Vision"),
                        new Competence("Marketing", "Simplicité"),
                        new Competence("Gestion", "Direction d'Entreprise")
                    },
                    0.0,
                    100.0
                    )
                );

            /***/

            PoolInterimaires.ajouter(
                new EmployeInterim("Mlle",
                    "Gorz",
                    "Gabrielle",
                    "0632124565",
                    new List<Competence>()
                    {
                        new Competence("Sport", "Football"),
                        new Competence("Sport", "Athletisme")
                    },
                    20.0,
                    0.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Dubosc",
                    "Franck",
                    "0696197532",
                    new List<Competence>()
                    {
                        new Competence("Télévision", "Comédie")
                    },
                    0.0,
                    20.3
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Riolo",
                    "Daniel",
                    "0625153565",
                    new List<Competence>(),
                    0.0,
                    15.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Herbunot",
                    "Killian",
                    "0660521235",
                    new List<Competence>()
                    {
                        new Competence("Sport", "Handball"),
                        new Competence("Danse", "Popping"),
                        new Competence("Informatique", "C#")
                    },
                    18.0,
                    0.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("M",
                    "Bailley",
                    "Mike",
                    "0656564585",
                    new List<Competence>()
                    {
                        new Competence("Danse", "Classique"),
                        new Competence("Musique", "Pop")
                    },
                    12.6,
                    0.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("Mme",
                    "Sheyti",
                    "Carole",
                    "0851236578",
                    new List<Competence>()
                    {
                        new Competence("Cuisine", "Antillaise"),
                        new Competence("Cuisine", "Indienne"),
                        new Competence("Cuisine", "Asiatique")
                    },
                    0.0,
                    10.0
                    )
                );

            PoolInterimaires.ajouter(
                new EmployeInterim("Mme",
                    "Bento",
                    "Koyo",
                    "0698654521",
                    new List<Competence>()
                    {
                        new Competence("Langue", "Japonais")
                    },
                    0.0,
                    5.0
                    )
                );

            PoolInterimaires.sauvegarderXml(nomFichier);
        }

        /**
         * La méthode firstInitPoolMissions permet de créer 6 missions
         */
	    public void firstInitPoolMissions(String nomFichier)
	    {
            PoolMissions.ajouter(
                new Mission(
                    new DateTime(2015, 01, 18),
                    new DateTime(2015, 02, 18),
                    "Nettoyage des locaux",
                    PoolEntreprisesClientes.EntreprisesClientes[0],
                    PoolInterimaires.Interimaires[0]
                    )
                );

            PoolMissions.ajouter(
                new Mission(
                    new DateTime(2015, 05, 18),
                    new DateTime(2015, 08, 18),
                    "Surveillance des locaux",
                    PoolEntreprisesClientes.EntreprisesClientes[1],
                    PoolInterimaires.Interimaires[1]
                    )
                );

            PoolMissions.ajouter(
                new Mission(
                    new DateTime(2015, 01, 1),
                    new DateTime(2015, 01, 31),
                    "Trier les dossiers",
                    PoolEntreprisesClientes.EntreprisesClientes[2],
                    PoolInterimaires.Interimaires[2]
                    )
                );

            PoolMissions.ajouter(
                new Mission(
                    new DateTime(2015, 06, 10),
                    new DateTime(2015, 09, 10),
                    "Prospecter pour le nouveau produit",
                    PoolEntreprisesClientes.EntreprisesClientes[3],
                    PoolInterimaires.Interimaires[3]
                    )
                );

            PoolMissions.ajouter(
                new Mission(
                    new DateTime(2015, 03, 1),
                    new DateTime(2015, 06, 30),
                    "Support téléphonique",
                    PoolEntreprisesClientes.EntreprisesClientes[4],
                    PoolInterimaires.Interimaires[4]
                    )
                );

            PoolMissions.ajouter(
                new Mission(
                    new DateTime(2015, 05, 18),
                    new DateTime(2015, 08, 18),
                    "Gestion du site internet",
                    PoolEntreprisesClientes.EntreprisesClientes[5],
                    PoolInterimaires.Interimaires[5]
                    )
                );

            PoolMissions.ajouter(
                new Mission(
                    new DateTime(2015, 05, 18),
                    new DateTime(2015, 08, 18),
                    "Correction de la rédaction",
                    PoolEntreprisesClientes.EntreprisesClientes[6],
                    PoolInterimaires.Interimaires[6]
                    )
                );

            PoolMissions.sauvegarderXml(@"PoolMissions.xml");
	    }
	}
}