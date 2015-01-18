
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

        /**
         * La méthode sauvegarderXml permet de sauvegarder le pool d'entreprises clientes dans un fichier XML
         */
        public void sauvegarderXml(String filename)
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

                using (TextWriter writer = new StreamWriter(PoolsXmlDir + filename))
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
	    public void chargerXml(String filename)
	    {
	        try
	        {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Entreprise>),
	                new XmlRootAttribute("PoolEntreprisesClientes"));

                String PoolsXmlDir = @"PoolsXML\";

                if (Directory.Exists(PoolsXmlDir))
                {
                    TextReader reader = new StreamReader(PoolsXmlDir + filename);

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