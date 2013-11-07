using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Fabrique
{
    public abstract class Medicament
    {
        private string nom;
        private int prescription;
        private int milligramme;

        public Medicament(string nom) 
        {
            this.nom = nom;
            this.prescription = 0;
            this.milligramme = 0;
        }

        public Medicament(string nom, int presc, int mg)
        {
            this.nom = nom;
            this.prescription = presc;
            this.milligramme = mg;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Milligramme
        {
            get { return milligramme; }
            set { milligramme = value; }
        }

        public int Prescription
        {
            get { return prescription; }
            set { prescription = value; }
        }

        public void getPosologie()
        {
            Console.WriteLine("Vous devez prendre un maximum de "+ this.Prescription.ToString() +
                              " comprimé de "+ this.Milligramme.ToString() + "mg de "+
                              this.Nom +" par jour.");
        }

    }
}
