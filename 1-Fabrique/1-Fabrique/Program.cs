using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Fabrique
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            string[] meds = new string[3] {"aspirine", "gravol", "tylenol"}; 

            Client jeanCoutu = new Client();

            Console.WriteLine("Client : Je ne me sens pas bien, je crois que j'ai besoin de médicaments, mais je ne connais pas la posologie.");
            Console.WriteLine("Pharmacien : Je vous conseille de prendre :");
            Console.WriteLine("1- Aspirine");
            Console.WriteLine("2- Gravol");
            Console.WriteLine("3- Tylenol");
            Console.WriteLine("4- Rien du tout (quitter)");

            Console.WriteLine("");
            Console.WriteLine("Choisir un chiffre :");

            while ((reponse = Console.ReadLine()) != "4")
            {
                if (String.Equals(reponse, "1") ||
                    String.Equals(reponse, "2") ||
                    String.Equals(reponse, "3"))
                {

                    jeanCoutu.Med = jeanCoutu.Factory.processusDeFabrication(meds[Int32.Parse(reponse) - 1]);
                    jeanCoutu.Med.getPosologie();
                }
            }

        }
    }
}
