using System;

namespace ExceptionLibrary
{
    public class DemoCode
    {
        public int GrandParentMethod(int position)
        {
            int output = 0;

            System.Console.WriteLine("Open Database Connection");

            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                throw; //new ArgumentException("You pass in bad data", ex);
            }
            finally
            {
                System.Console.WriteLine("Close Database Connection");
            }
            return output;
        }
        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }
        public int GetNumber(int position)
        {
            var output = 0;
            //try
            //{
            var numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            return output;
        }
    }
}
