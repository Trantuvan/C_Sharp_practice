﻿using Amazon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            RateCalculator cal = new RateCalculator();
        }
    }
}
