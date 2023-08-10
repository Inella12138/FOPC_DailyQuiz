using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Quiz
{
    internal class Day_5_Quiz
    {
        static void Main(string[] args)
        {
            int[,] theArray = new int[,]
            {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7}
            };

            int count = 0;

            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    if (theArray[i,j] == input)
                    {
                        count++;
                    }
                }
            }

            if (count != 0)
            {
                Console.WriteLine("The number {0} appeared for {1} times.",input, count);
            }
            else { Console.WriteLine("The number {0} did not appeared.",input); }
            
        }

    }
}
