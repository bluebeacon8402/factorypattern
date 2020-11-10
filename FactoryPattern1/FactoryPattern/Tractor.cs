using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Tractor : IFarm
    {
        IFarm farm2;

        public Tractor ()
        {
            Console.WriteLine("Congratulations you got a new tractor!");
        }
    }
}
