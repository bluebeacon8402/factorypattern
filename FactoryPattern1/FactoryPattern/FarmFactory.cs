using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class FarmFactory
    {

        public static IFarm GetObject()
        {
            Console.WriteLine("What do you need for your farm?");
            var object1 = Console.ReadLine();
            
            if (object1.ToLower() == "apple")
            {
                return new Crop(); 
            }
            else
            {
                return new Tractor();
            }
        }

    }
}
