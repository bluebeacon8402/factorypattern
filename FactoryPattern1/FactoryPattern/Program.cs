using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new console app that utilizes factory pattern by taking a user’s input of how many tires are on a vehicle and based on their input, creates that type of vehicle.Complete this using an interface. You must have at least 3 subclasses.For instance, if I type 4 into the console, the program would create a car or truck, or if someone types 2 it would create a motorcycle.

            //Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!

            //Possible steps:
            //Create an Interface named IVehicle that has a stubbed out public void Drive method - DONE
            //Create 2 new public classes that will conform to IVehicle - DONE
            //Example) Car, Motorcycle,  BigRig
            //These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)
            //Now we will make our static VehicleFactory class
            //It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
            //Call this functionality in the Main method
            var farmObject = FarmFactory.GetObject();




        }
    }
}
