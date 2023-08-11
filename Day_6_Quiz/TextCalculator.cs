using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Quiz.Day_6_Quiz
{
    internal class TextCalculator
    {
        //these arrays is visible in all the static method, 
        //so you can use them in your method implementation

        static int[] minIncomeArray = new int[]
            { 20000, 30000, 40000, 80000,
              120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
            { 0.02, 0.035, 0.07, 0.115,
              0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
            { 0, 200, 550, 3350,
              7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
                CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        //YOUR CODE HERE

        static int AskForIncome()
        {
            bool flag;
            int income;
            while (true)
            {
                Console.Write("Please enter your annual taxable income: ");
                string userinp = Console.ReadLine();
                flag = Int32.TryParse(userinp, out income);
                if (flag) { break; }
                Console.WriteLine("Please check your input and try again!");
            }
            return income;
        }

        static int GetTaxBracket(int income)
        {
            int index = -1;
            int len = minIncomeArray.Length;
            for (int i = 0; i < len; i++)
            {               
                if (minIncomeArray[len - 1 - i] < income)
                { index = len - 1 - i; break; }
            }
            return index;
        }

        static double CalculateIncomeTax(int income, int index)
        {
            double tax;
            if (index == -1) { tax = 0; }
            else
            {
                int minIncome = minIncomeArray[index];
                double taxrate = taxRateArray[index];
                int basepay = basePayableAmountArray[index];
                tax = (income - minIncome) * taxrate + basepay;
            }
            return tax;
        }

        static void PrintResult(int income, double tax)
        {
            Console.WriteLine("For taxable annual income of ${0:0.00},the tax payable amount is ${1:0.00}", income, tax);
        }





    }
}
