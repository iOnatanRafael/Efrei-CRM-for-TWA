
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using TwaCRM.interimaire;

namespace TwaCRM.pool{
    /**
     * La classe PoolInterimaires modélise la liste des employés interimaires
     */
    public class PoolInterimaires {

		/**
		 * Constructeur par défaut
		 */
		public PoolInterimaires() {
            Interimaires = new List<EmployeInterim>();
		}

		/**
		 * Contient la liste des employés interimaires
		 */
        private List<EmployeInterim> _interimaires;
        public List<EmployeInterim> Interimaires
        {
            get { return _interimaires; }
            set { _interimaires = value; }
        }



		/**
		 * @return la liste de tous les employés interimaires
		 */
        public List<EmployeInterim> getPool()
        {
			return Interimaires;
		}

        /**
         * @param searchedWord 
         * @return le ou les interimaire(s) dont un critère contient `searchedWord`
         */
        public List<EmployeInterim> chercher(String searchedWord)
        {
            IEnumerable<EmployeInterim> searchQuery =
                from interimaire in Interimaires
                where interimaire.Nom.Contains(searchedWord) ||
                        interimaire.Prenom.Contains(searchedWord) ||
                        interimaire.Telephone.Contains(searchedWord) ||
                        interimaire.TarifJournalierFixe.ToString().Equals(searchedWord) ||
                        interimaire.TarifJournalierVariable.ToString().Equals(searchedWord) ||
                        interimaire.Competences.Exists(x => x.Categorie.Contains(searchedWord)) ||
                        interimaire.Competences.Exists(x => x.Nom.Contains(searchedWord))
                select interimaire;

            return searchQuery.ToList();
		}

		/**
		 * @param EmployeInterim 
		 * @return true si l'ajout a été réussi, sinon false
		 */
		public bool ajouter(EmployeInterim interimaire) {
		    if (interimaire != null)
		    {
		        Interimaires.Add(interimaire);
		        return true;
		    }
            return false;
		}

        /**
         * @param nom 
         * @return true si la suppression a été réussi, sinon false
         */
        public bool supprimer(EmployeInterim interimaireASupprimer) {
            int delete = Interimaires.RemoveAll(x => x.Equals(interimaireASupprimer));

            if (delete > 0)
            {
                return true;
            }

            return false;
        }

        /**
         * La méthode sauvegarderXml permet de sauvegarder le pool d'interimaires dans un fichier XML
         */
        public void sauvegarderXml(String filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<EmployeInterim>),
                    new XmlRootAttribute("PoolInterimaires"));

                String PoolsXmlDir = @"PoolsXML\";

                if (!Directory.Exists(PoolsXmlDir))
                {
                    Directory.CreateDirectory(PoolsXmlDir);
                }

                using (TextWriter writer = new StreamWriter(PoolsXmlDir + filename))
                {
                    serializer.Serialize(writer, this.Interimaires);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        /**
         * La méthode chargerXml permet de charger le pool d'entreprises clientes à partir d'un fichier XML
         */
        public void chargerXml(String filename)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<EmployeInterim>),
                    new XmlRootAttribute("PoolInterimaires"));

                String PoolsXmlDir = @"PoolsXML\";

                if (Directory.Exists(PoolsXmlDir))
                {
                    TextReader reader = new StreamReader(PoolsXmlDir + filename);

                    Object obj = deserializer.Deserialize(reader);
                    Interimaires = (List<EmployeInterim>)obj;
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