using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                FizzBuzz(i);
            }
            for (int i = 92; i > 79; i--)
            {
                FizzBuzz(i);
            }
            Yodaizer("i like code");
            TextStats("i. like. code.?");
            for (int i = 1; i < 26; i+=2)
			{
			 IsPrime(i);
			}
            DashInsert(8675309);
            Console.ReadKey();
        }


        static void FizzBuzz(int number)
        {
            if (number == 0)
            {
                Console.WriteLine(number);
            }
            else if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static void Yodaizer(string text)
        {
            Console.WriteLine();
            List<string> wordList = text.Split(' ').ToList();
            for (int i = wordList.Count() - 1; i >= 0 ; i--)
            {
                string currentWord = wordList[i];
                Console.Write(currentWord + " ");
            }
            Console.WriteLine();
        }
        static void TextStats(string input)
        {
            int numberOfCharacters = 0;
            int numberOfWords = 0;
            int numberOfVowels = 0;
            int numberOfConsonants = 0;
            int numberOfSpecialCharacters = 0;
            string[] stringArray = input.Split(' ');
            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                numberOfCharacters++;
                string currentLetter = input[i].ToString().ToLower();
                if ("aeiou".Contains(currentLetter))
                {
                    numberOfVowels++;
                }
                else if (" .?".Contains(currentLetter))
                {
                    numberOfSpecialCharacters++;
                }
                else
                {
                    numberOfConsonants++;
                }
            }
                numberOfWords = stringArray.Length;
 
            Console.WriteLine("Number of characters: " +numberOfCharacters);
            Console.WriteLine("Number of words: " + numberOfWords);
            Console.WriteLine("Number of vowels: " + numberOfVowels);
            Console.WriteLine("Number of consonants: " + numberOfConsonants);
            Console.WriteLine("Number of special characters: " + numberOfSpecialCharacters);
             }

        static void IsPrime(int number)
        {
            int divisors = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors++;
                }
            }
            if (divisors == 2)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static void DashInsert(int number)
        {
            string input = number.ToString();
            string outputString = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentDigit = int.Parse (input[i].ToString());
                int nextDigit = int.Parse(input[i + 1].ToString());
                if (currentDigit % 2 != 0 && nextDigit % 2 != 0)
	{
		 outputString += currentDigit + "-";
	}
                else
	{
                    outputString += currentDigit;
	}
            }
            outputString += input[input.Length - 1];
            Console.WriteLine("Dash number: " + outputString);
        }   
    }
}
