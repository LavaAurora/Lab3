using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_FabriqueAbstraite
{
    class Client
    {
        private string nom;
        private FabriqueAbstraite fabrique;
        private MedA medA;
        private MedB medB;

        private Client(){}

        public Client(string nom, string type)
        {
            this.nom = nom;
            this.fabrique = FabriqueAbstraite.getFabrique(type);
            this.medA = this.fabrique.creerMedicamentA();
            this.medB = this.fabrique.creerMedicamentB();
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public FabriqueAbstraite Fabrique
        {
            get { return fabrique; }
            set { fabrique = value; }
        }

        public MedA MedA
        {
            get { return medA; }
            set { medA = value; }
        }

        public MedB MedB
        {
            get { return medB; }
            set { medB = value; }
        }

        public override string ToString()
        {
            return "Le " + this.nom + " possède " + this.MedA.NomMedicament + " et " + this.MedB.NomMedicament + ".";
        }


    }
}
