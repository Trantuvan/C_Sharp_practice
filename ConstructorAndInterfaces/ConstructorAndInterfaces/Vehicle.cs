using System;

namespace ConstructorAndInterfaces
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initaized {0}", registrationNumber);
        }

    }    
}
