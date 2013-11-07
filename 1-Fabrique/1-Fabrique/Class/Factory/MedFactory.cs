using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Fabrique
{
    public abstract class MedFactory
    {
        public abstract Medicament processusDeFabrication(string typeMedicament);

    }
}
