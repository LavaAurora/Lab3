using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_FabriqueAbstraite
{
    class FabriqueNonGenerique :FabriqueAbstraite
    {
        public override MedA creerMedicamentA()
        {
            return new MedNonGeneriqueA();

            throw new NotImplementedException();
        }

        public override MedB creerMedicamentB()
        {
            return new MedNonGeneriqueB();

            throw new NotImplementedException();
        }
    }
}
