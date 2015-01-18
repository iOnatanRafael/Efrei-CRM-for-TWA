
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using TwaCRM.entreprise;
using TwaCRM.interimaire;
using TwaCRM.mission;

namespace TwaCRM.pool{
	/**
	 * La classe PoolMissions modélise la liste des missions
	 */
	public class PoolMissions {

		/**
		 * Constructeur par défaut
		 */
		public PoolMissions() {
            Missions = new List<Mission>();
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
		 * @return la liste de toutes les missions
		 */
        public List<Mission> getPool()
        {
			return Missions;
		}

        /**
         * @param entreprise 
         * @return la liste des missions soumises par l'entreprise `entreprise`
         */
        public List<Mission> getPoolParEntreprise(Entreprise entreprise)
        {
            IEnumerable<Mission> filteredQuery =
                from mission in Missions
                where mission.Entreprise.Equals(entreprise)
                select mission;

			return filteredQuery.ToList();
		}

        /**
         * @param interimaire 
         * @return la liste des missions associées à l'intérimaire `interimaire`
         */
        public List<Mission> getPoolParEmployeInterim(EmployeInterim interimaire)
        {
            IEnumerable<Mission> filteredQuery =
                from mission in Missions
                where mission.EmployeInterim.Equals(interimaire)
                select mission;

            return filteredQuery.ToList();
		}

        /**
         * @param searchedWord 
         * @return la liste des missions dont un critère contient `searchedWord`
         */
        public List<Mission> chercher(String searchedWord)
        {
            IEnumerable<Mission> searchQuery =
                from mission in Missions
                where mission.DateDebut.ToString().Contains(searchedWord) ||
                        mission.DateFin.ToString().Contains(searchedWord) ||
                        mission.Tache.Contains(searchedWord) ||
                        mission.Entreprise.Nom.Contains(searchedWord) ||
                        mission.Entreprise.Adresse.Voie.Contains(searchedWord) ||
                        mission.Entreprise.Adresse.CodePostal.Contains(searchedWord)||
                        mission.Entreprise.Adresse.Ville.Contains(searchedWord) ||
                        mission.Entreprise.Adresse.Pays.Contains(searchedWord) ||
                        mission.EmployeInterim.Nom.Contains(searchedWord) ||
                        mission.EmployeInterim.Prenom.Contains(searchedWord) ||
                        mission.EmployeInterim.Telephone.Contains(searchedWord) ||
                        mission.EmployeInterim.Competences.Exists(x => x.Categorie.Contains(searchedWord)) ||
                        mission.EmployeInterim.Competences.Exists(x => x.Nom.Contains(searchedWord)) ||
                        mission.EmployeInterim.TarifJournalierFixe.ToString().Equals(searchedWord) ||
                        mission.EmployeInterim.TarifJournalierVariable.ToString().Equals(searchedWord)
                select mission;

            return searchQuery.ToList();
		}

        /**
         * @param Mission 
         * @return true si l'ajout a été réussi, sinon false
         */
        public bool ajouter(Mission missionAAjouter) {
            // Vérifier si la mission existe et est correcte (date début antérieure à date fin)
            if (missionAAjouter != null && missionAAjouter.DateDebut.CompareTo(missionAAjouter.DateFin) <= 0)
            {
                IEnumerable<Mission> conflictQuery =
                    from mission in Missions
                    where mission.EmployeInterim.UniqueId == missionAAjouter.EmployeInterim.UniqueId &&
                            (mission.DateDebut.CompareTo(missionAAjouter.DateDebut) <= 0 && mission.DateFin.CompareTo(missionAAjouter.DateDebut) >= 0) ||
                            (mission.DateDebut.CompareTo(missionAAjouter.DateFin) <= 0 && mission.DateFin.CompareTo(missionAAjouter.DateFin) >= 0)
                    select mission;

                if (!conflictQuery.Any())
                {
                    Missions.Add(missionAAjouter);
                    return true;
                }
            }

            return false;
		}

        /**
         * La méthode sauvegarderXml permet de sauvegarder le pool de missions dans un fichier XML
         */
        public void sauvegarderXml(String filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Mission>),
                    new XmlRootAttribute("PoolMissions"));

                String PoolsXmlDir = @"PoolsXML\";

                if (!Directory.Exists(PoolsXmlDir))
                {
                    Directory.CreateDirectory(PoolsXmlDir);
                }

                using (TextWriter writer = new StreamWriter(PoolsXmlDir + filename))
                {
                    serializer.Serialize(writer, this.Missions);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        /**
         * La méthode chargerXml permet de charger le pool de missions à partir d'un fichier XML
         */
        public void chargerXml(String filename)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Mission>),
                    new XmlRootAttribute("PoolMissions"));

                String PoolsXmlDir = @"PoolsXML\";

                if (Directory.Exists(PoolsXmlDir))
                {
                    TextReader reader = new StreamReader(PoolsXmlDir + filename);

                    Object obj = deserializer.Deserialize(reader);
                    Missions = (List<Mission>)obj;
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

	}
}