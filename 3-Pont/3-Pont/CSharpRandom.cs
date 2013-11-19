using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Pont
{
    class CSharpRandom : IRandomImpl
    {
        private System.Random random;

        public void Random()
        {
            System.Console.WriteLine("CSharpRandom.Random exécuté.");
            random = new System.Random();
        }

        public int Next(int number)
        {
            System.Console.WriteLine("CSharpRandom.Next exécuté.");
            return random.Next(number);
        }
    }
}
