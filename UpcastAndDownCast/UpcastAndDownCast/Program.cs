using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastAndDownCast
{
    class Program
    {
        static void Main(string[] args)
        {   /*Upcasting */
            /*// is keyword use to check the type of obj
            // as keyword use to cast type instead of return an exception like explicit, it return a null value 
            Text text = new Text();
            // shape and text reference to same object in memory but have different view (text co view rong hon cua rieng Text)
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);*/

            //StreamReader reader = new StreamReader(new MemoryStream());

            /*ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());

            var anotherList = new List<Shape>();*/

            /*DownCasting*/
            Shape shape = new Text();
            Text text = (Text) shape;

        }
    }
}
