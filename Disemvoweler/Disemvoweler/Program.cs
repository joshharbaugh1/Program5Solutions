using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine();
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears");
            Console.WriteLine();
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }

        static void Disemvoweler(string input)
        {
            string consonants = "";
            string vowels = "";
            string consonantsLookingFor = "bcdfghjklmnpqrstvwxyz";
            consonantsLookingFor += consonantsLookingFor.ToUpper();
            string vowelsLookingFor = "aeiou";
            vowelsLookingFor += vowelsLookingFor.ToUpper();

            for (int i = 0; i < input.Length; i++)
			{
			 if (vowelsLookingFor.Contains (input[i]))
                {
                    vowels += input[i];
                }
             if (consonantsLookingFor.Contains (input[i])) 
                {
                    consonants += input[i];
                }
			}
            Console.WriteLine(consonants);
            Console.WriteLine("Vowels Removed: " + vowels);
        }
    }
}
