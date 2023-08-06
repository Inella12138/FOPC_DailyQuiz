using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Daily_Quiz
{
    internal class Day_2_Quiz
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length in cm:");
            double lengthIncm = double.Parse(Console.ReadLine());
            // The sentence below also works:
            // double lengthIncm = Convert.ToDouble(Console.ReadLine());
            // The main difference between Parse and Convert is when given a 
            // null value, Parse returns a warning while Convert returns 0

            double lengthIninch = lengthIncm / 2.54;
            Console.WriteLine($"{lengthIninch:0.000}");
            // The sentence below also works:
            Console.WriteLine("{0:0.000}",lengthIninch);
            //Do note that in {}, if a number is used, it attributes to the 
            //variable after in order, if a variable is used, a "$" must be
            //written before "" to show the value of the variable
        }
    }
}
