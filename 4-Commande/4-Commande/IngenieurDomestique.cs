using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Commande
{
    class IngenieurDomestique : ICommande
    {
        public void Execute()
        {
            Console.WriteLine("Execute la méthode de l'ingénieur!");
        }
    }
}
