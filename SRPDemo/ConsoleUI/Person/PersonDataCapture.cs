using System;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            //ask for user info
            var output = new Person();

            Console.WriteLine("What is your 1st name");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
