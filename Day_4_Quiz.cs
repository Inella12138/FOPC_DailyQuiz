using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Quiz
{
    internal class Day_4_Quiz
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            string PIN = "192837";
            int i = 1;
            while (i < 4) 
            {
                Console.WriteLine("Enter your PIN: ");
                string user =Console.ReadLine();
                if (user.Equals(PIN)) 
                {
                    Console.WriteLine("PIN accepted. You can access your account now");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine("Too many wrong PIN entries. Your account is now locked");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN. Please try again");
                    }
                }               
                i++;
            }
        }
    }
}
