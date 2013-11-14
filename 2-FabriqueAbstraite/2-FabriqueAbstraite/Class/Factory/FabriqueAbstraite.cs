using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_FabriqueAbstraite
{
    abstract class FabriqueAbstraite
    {
        public static FabriqueAbstraite getFabrique(string type)
        {
            if (type.ToLower().Equals("g"))
                return (new FabriqueGenerique());
            else
                return (new FabriqueNonGenerique());
        }

        public abstract MedA creerMedicamentA();
        public abstract MedB creerMedicamentB();
    }
}
