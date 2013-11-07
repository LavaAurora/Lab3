using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Fabrique
{
    public class MedXFactory : MedFactory
    {
        public override Medicament processusDeFabrication(string typeMedicament)
        {
            if (String.Equals(typeMedicament.ToLower(), "aspirine"))
                return new Aspririne();
            else if (String.Equals(typeMedicament.ToLower(), "gravol"))
                return new Gravol();
            else if (String.Equals(typeMedicament.ToLower(), "tylenol"))
                return new Tylenol();

            throw new NotImplementedException();
        }
    }
}
