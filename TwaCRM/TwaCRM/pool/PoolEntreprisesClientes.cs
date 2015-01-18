
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using TwaCRM.entreprise;

namespace TwaCRM.pool{
	/**
	 * La classe PoolEntreprisesClientes modélise la liste des entreprises clientes
	 */
	public class PoolEntreprisesClientes {

        /**
         * Constructeur par défaut
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
		 * @return la liste de toutes les entreprises clientes
		 */
        public List<Entreprise> getPool()
        {
			return EntreprisesClientes;
		}

        /**
         * @param searchedWord
         * @return la liste des entreprises dont un critère contient `searchedWord`
         */
        public List<Entreprise> chercher(string searchedWord)
        {
            IEnumerable<Entreprise> searchQuery =
                from entreprise in EntreprisesClientes
                where entreprise.Nom.Contains(searchedWord) ||
                        entreprise.Adresse.Voie.Contains(searchedWord) ||
                        entreprise.Adresse.CodePostal.Contains(searchedWord) ||
                        entreprise.Adresse.Ville.Contains(searchedWord) ||
                        entreprise.Adresse.Pays.Contains(searchedWord) ||
                        entreprise.Siret.ToString().Contains(searchedWord) ||
                        entreprise.Contact.Nom.Contains(searchedWord) ||
                        entreprise.Contact.Prenom.Contains(searchedWord) ||
                        entreprise.Contact.Telephone.Contains(searchedWord) ||
                        entreprise.Contact.Role.Contains(searchedWord)
                select entreprise;

			return searchQuery.ToList();
		}

        /**
         * @param entreprise 
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
         * La méthode sauvegarderXml permet de sauvegarder le pool d'entreprises clientes dans un fichier XML
         */
        public void sauvegarderXml(String nomFichier)
	    {
	        try
	        {
	            XmlSerializer serializer = new XmlSerializer(typeof(List<Entreprise>),
	                new XmlRootAttribute("PoolEntreprisesClientes"));

	            String PoolsXmlDir = @"PoolsXML\";

	            if (!Directory.Exists(PoolsXmlDir))
	            {
	                Directory.CreateDirectory(PoolsXmlDir);
	            }

                using (TextWriter writer = new StreamWriter(PoolsXmlDir + nomFichier))
	            {
	                serializer.Serialize(writer, this.EntreprisesClientes);
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
        public void chargerXml(String nomFichier)
	    {
	        try
	        {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Entreprise>),
	                new XmlRootAttribute("PoolEntreprisesClientes"));

                String PoolsXmlDir = @"PoolsXML\";

                if (Directory.Exists(PoolsXmlDir))
                {
                    TextReader reader = new StreamReader(PoolsXmlDir + nomFichier);

                    Object obj = deserializer.Deserialize(reader);
                    EntreprisesClientes = (List<Entreprise>)obj;
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