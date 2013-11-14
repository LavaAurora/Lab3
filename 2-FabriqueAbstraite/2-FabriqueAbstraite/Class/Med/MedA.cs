using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_FabriqueAbstraite
{
    abstract class MedA
    {
        private string nomMedicament;

        public string NomMedicament
        {
            get { return nomMedicament; }
            set { nomMedicament = value; }
        }
    }
}
