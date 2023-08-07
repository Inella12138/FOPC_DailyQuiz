using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Quiz
{
    internal class Day_3_Quiz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISS Gadget Shop!");
            Console.Write("Numbers of items to purchase: ");
            double value = 500*int.Parse(Console.ReadLine());
            if (value > 2000 && value <= 3000) { value = value * 0.97; }
            if (value > 3000 && value <= 6000) { value = value * 0.95; }
            if (value > 6000) { value = value * 0.92; }
            Console.WriteLine($"\n Please pay ${value:0.00}");
        }
    }
}
