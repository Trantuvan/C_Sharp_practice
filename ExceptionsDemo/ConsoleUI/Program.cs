using ExceptionLibrary;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var demo = new DemoCode();

            try
            {
                var result = demo.GrandParentMethod(4);
                Console.WriteLine($"The value at the given position is {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You gave us bad information. Bad user!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
            Console.ReadLine();
        }
    }
}
