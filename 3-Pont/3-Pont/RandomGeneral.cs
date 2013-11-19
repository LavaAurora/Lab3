using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Pont
{
    class RandomGeneral
    {
        protected IRandomImpl iRandomImpl;

        public RandomGeneral() { }

        public void Random(string name)
        {
            if (name.Equals(Program.mien))
            {
                iRandomImpl = new MonRandom();
            }
            else if (name.Equals(Program.csharp))
            {
                iRandomImpl = new CSharpRandom();   
            }
        }

        public virtual void Random()
        {
            System.Console.WriteLine("RandomGeneral.Random exécuté.");
            iRandomImpl.Random();
        }

        public virtual int Next(int number)
        {
            System.Console.WriteLine("RandomGeneral.Next exécuté.");
            return iRandomImpl.Next(number);
        }
    }
}
