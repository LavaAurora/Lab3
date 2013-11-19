using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Commande
{
    /*
     *  NB : le main n'est pas dans la classe ClientCommande, car on ne peut pas
     *       déclarer de variable de classe dans une classe possédant un main.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            ClientCommande client = new ClientCommande();

            //Exécute les requêtes grace à la commande
            //(le client n'a pas "connaissance" des objets
            //Programmeur, Politicien et Ingénieur domestique)
            client.EnvoiDesRequetes();

            Console.ReadLine();
        }
    }
}
