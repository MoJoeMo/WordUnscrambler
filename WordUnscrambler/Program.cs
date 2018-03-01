using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;

            do
            {
                Console.WriteLine("Please enter option: M or F");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("enter scrambled words file name: ");
                        ExecuteScrambledWordsFromFile();
                        break;
                    case "M":
                        Console.WriteLine("Enter scrambled words manually: ");
                        ExecuteScrambledWordsFromEntry();
                        break;
                    default:
                        Console.Write("option not recognized");
                        break;
                }

                var continueWordUnscrambleDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue?");
                    continueWordUnscrambleDecision = Console.ReadLine() ?? string.Empty;

                } while (!continueWordUnscramble.Equals("Y", StringComparison.OrdinalIgnoreCase && 
                         !continueWordUnscramble.Equals("N", StringComparison.OrdinalIgnoreCase)));

                continueWordUnscramble = continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambledWordsFromEntry()
        {
            throw new NotImplementedException();
        }

        private static void ExecuteScrambledWordsFromFile()
        {
            throw new NotImplementedException();
        }
    }
}
