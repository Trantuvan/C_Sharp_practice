using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugWithTimCorey
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FristName = "Van",
                LastName = "Tran"
            };
            Console.WriteLine(person.FunkyNameBuilder());
        }
    }
}
