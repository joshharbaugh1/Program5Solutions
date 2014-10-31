using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_and_Word_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterFinder3000("this sentence has truly a ton of t's in it", "t");
            Console.ReadKey();
        }

        static void LetterFinder3000(string inputString, string letter)
        {
            int letterCounter = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                string currentLetter = inputString[i].ToString().ToLower();
                if (currentLetter == letter.ToLower())
                {
                    letterCounter++;
                }
            }
            Console.WriteLine(inputString + " has " + letterCounter + " in it");
        }
 

    }
}
