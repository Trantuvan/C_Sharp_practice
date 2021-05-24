using System;

namespace Inheritance
{
    public class PresentationObject
    {
        // properties public; nhung var luu witdth & height auto generate la private
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}