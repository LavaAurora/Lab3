using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_FabriqueAbstraite
{
    class FabriqueGenerique :FabriqueAbstraite
    {
        public override MedA creerMedicamentA()
        {
            return new MedGeneriqueA();

            throw new NotImplementedException();
        }

        public override MedB creerMedicamentB()
        {
            return new MedGeneriqueB();

            throw new NotImplementedException();
        }
    }
}
