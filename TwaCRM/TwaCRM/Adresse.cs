
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM{
	/**
	 * La classe Adresse modélise une adresse associée à une entreprise
	 */
	public class Adresse {

		/**
         * Constructeur
         */
	    public Adresse(String numero, String voie, String codePostal, String ville, String pays)
	    {
	        Numero = numero;
	        Voie = voie;
	        CodePostal = codePostal;
	        Ville = ville;
	        Pays = pays;
	    }

        /**
         * Contient le numéro de l'adresse
         */
        private String _numero;
        public String Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

		/**
		 * Contient la voie de l'adresse (ex.: boulevard Stalingrad)
		 */
	    private String _voie;
	    public String Voie
	    {
            get { return _voie; }
            set { _voie = value; }
	    }

		/**
		 * Contient le code postal de l'adresse
		 */
	    private String _codePostal;
	    public String CodePostal
	    {
            get { return _codePostal; }
	        set { _codePostal = value; }
	    }

		/**
		 * Contient la ville de l'adresse
		 */
		private String _ville;
	    public String Ville
	    {
            get { return _ville; }
            set { _ville = value; }
	    }

		/**
		 * Contient le pays de l'adresse
		 */
	    private String _pays;
	    public String Pays
	    {
            get { return _pays; }
            set { _pays = value; }
	    }

        /**
         * Surcharge de l'opérateur ToString
         */
	    public override string ToString()
	    {
	        return Numero + ", " + Voie + " - " + Ville + " (" + CodePostal + ") - " + Pays;
	    }
	}
}