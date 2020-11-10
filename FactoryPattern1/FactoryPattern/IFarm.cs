using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FactoryPattern
{
    public interface IFarm
    {
       public void Drive()
        {
             Console.WriteLine("You are driving a tractor now!");
        }

    }
}
