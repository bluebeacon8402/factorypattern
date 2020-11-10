using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Crop: IFarm
    {
       
        public Crop ()
        {
            Console.WriteLine("Congratulations you have planted some crops!");
        }
    }
}
