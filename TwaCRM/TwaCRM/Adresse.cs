
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM{
	/**
	 * 
	 */
	public class Adresse {

		/**
		 * 
		 */
		public Adresse() {
		}

		/**
		 * Contient la voie de l'adresse (ex.: boulevard Stalingrad)
		 */
	    private String voie;
	    public String Voie
	    {
            get { return voie; }
            set { this.voie = value; }
	    }

		/**
		 * 
		 */
		private int codePostal;

		/**
		 * 
		 */
		private String ville;

		/**
		 * 
		 */
		private String pays;


	}
}