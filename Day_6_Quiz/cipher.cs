using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Quiz.Day_6_Quiz
{
    internal class cipher
    {
        static void Main(string[] args)
        {
            string upperPlainText = ReturnUpperInputSentence();

            string encryptedText = EncryptSentence(upperPlainText);

            PrintEncryptedSentence(encryptedText);

            string decryptedText = DecryptSentence(encryptedText);

            PrintDecryptedSentence(decryptedText);

            Console.WriteLine("\nType any key to exit.");
            Console.ReadLine();
        }
        //YOUR CODE HERE

        static string ReturnUpperInputSentence()
        {
            Console.Write("Please enter the sentence: ");
            string userinp = Console.ReadLine();
            userinp = userinp.ToUpper();
            return userinp;
        }

        static string EncryptSentence(string input)
        {
            int len = input.Length;
            string result = "";
            for (int i = 0; i < len; i++)
            {
                char inp = input[i];
                int t;
                if (char.IsLetter(inp))
                {
                    if (inp < 'X') {t = inp + 3; }
                    else { t = inp - 23; }
                    inp = Convert.ToChar(t);
                }
                result = result + Convert.ToString(inp);
            }
            return result;
        }

        static void PrintEncryptedSentence(string input)
        {
            Console.WriteLine("The encrypted sentence is : " + input);
        }

        static string DecryptSentence(string input)
        {
            int len = input.Length;
            string result = "";
            for (int i = 0; i < len; i++)
            {
                char inp = input[i];
                int t;
                if (char.IsLetter(inp))
                {
                    if (inp > 'C') { t = inp - 3; }
                    else {t=inp+23; }
                    inp = Convert.ToChar(t);
                }
                result = result + Convert.ToString(inp);
            }
            return result;
        }

        static void PrintDecryptedSentence(string input)
        {
            Console.WriteLine("The decrypted sentence is : " + input);
        }
    }
}
