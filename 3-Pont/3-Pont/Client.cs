using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Pont
{
    class Client
    {
        private RandomGeneral[] randoms;

        public Client()
        {
            randoms = new RandomGeneral[] {
                new RandomGeneral(),
                new RandomGeneral(),
                new RandomAffinee(),
                new RandomAffinee()
            };

            randoms[0].Random(Program.mien);
            randoms[1].Random(Program.csharp);
            randoms[2].Random(Program.mien);
            randoms[3].Random(Program.csharp);

            foreach (var rand in randoms)
            {
                rand.Random();
                System.Console.WriteLine("Résultat du random : {0} \n", rand.Next(1000));
                System.Threading.Thread.Sleep(100);
            }
        }

    }
}