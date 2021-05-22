using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            //indexers is a properties using when a class has a list or dictionary
            var cookie = new HttpCookie();
            cookie["name"] = "Van";
            Console.WriteLine(cookie["name"]);
        }
    }
}
