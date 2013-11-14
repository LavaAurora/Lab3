using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_FabriqueAbstraite
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Client1", "g");
            Client client2 = new Client("Client2", "ng");

            Console.WriteLine(client1.ToString());
            Console.WriteLine(client2.ToString());

            Console.ReadLine();

        }
    }
}
