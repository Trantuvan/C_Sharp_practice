using System;

namespace ConstructorAndInterfaces
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {    
            // base constructor always execute 1st
            // child class phai re declare constuctor chu khong huong cua parent
            // muon huong phai co keyword base(parameter) (base dai dien cho ctor of parent)
            // dung base de goi bat cu ctor nao tu parent tranh default paraless ctor
            Console.WriteLine("Car is being initialzed. {0}", registrationNumber);
        }
    }   
}
