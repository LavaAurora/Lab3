using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Commande
{
    public class Programmeur : ICommande
    {
        public void Execute()
        {
            Console.WriteLine("Execute la méthode du programmeur!");
        }
    }
}
