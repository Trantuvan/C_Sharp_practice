using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            // this la instance current class
            var rating = calculator.Calculate(this);
              
            Console.WriteLine("Promoted logic changed.");
        }
    }
}
