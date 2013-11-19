using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Fabrique
{
    public class Client
    {
        private MedXFactory factory;
        private Medicament med;

        public Client()
        {
            this.factory = new MedXFactory();
        }

        public MedXFactory Factory
        {
            get { return factory; }
            set { factory = value; }
        }

        public Medicament Med
        {
            get { return med; }
            set { med = value; }
        }
    }
}
