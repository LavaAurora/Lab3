using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Pont
{
    class RandomAffinee : RandomGeneral
    {
        public RandomAffinee() { }

        public override void Random()
        {
            System.Console.WriteLine("RandomAffinee.Random exécuté.");
            iRandomImpl.Random();
        }

        public override int Next(int number)
        {
            System.Console.WriteLine("RandomAffinee.Next exécuté.");
            return iRandomImpl.Next(number);
        }
    }
}
