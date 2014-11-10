using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the ChangeMaker function
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
            ChangeMaker(625.09);
            Console.ReadKey();
        }
        //making the ChangeMaker function
        static void ChangeMaker(double dollarsAndCents)
        {
            Console.WriteLine("I have $" + dollarsAndCents + ", heres some change.\n");
            int totalCents = (int)Math.Round(dollarsAndCents*100, 2);

            //making all of the counters
             int numOfHunneds = 0;
            int numOfFiddys = 0;
            int numOfTwennes = 0;
            int numOfTens = 0;
            int numOfLincolns = 0;
            int numOfWashintuns = 0;
            int numOfQuarters = 0;
            int numOfDimeBags = 0;
            int numOfNickelSocks = 0;
            int numOfPennies = 0;

            //taking the totalCents and setting it equal to 10000 because
            // thats how many pennies are in 100 dollars
             if (totalCents >= 10000)
            {
                numOfHunneds += totalCents / 10000;
                totalCents -= 10000 * numOfHunneds;
            }
            //taking totalCents and setting it equal to 5000 because
            //thats how many pennies are in 50 dollars
            if (totalCents >= 5000)
            {
                numOfFiddys += totalCents / 5000;
                totalCents -= 5000 * numOfFiddys;
            }
            
            if (totalCents >= 2000)
            {
                numOfTwennes += totalCents / 2000;
                totalCents -= 2000 * numOfTwennes;
            } if (totalCents >= 1000)
            {
                numOfTens += totalCents / 1000;
                totalCents -= 1000 * numOfTens;
            } if (totalCents >= 500)
            {
                numOfLincolns += totalCents / 500;
                totalCents -= 500 * numOfLincolns;
            } if (totalCents >= 100)
            {
                numOfWashintuns += totalCents / 100;
                totalCents -= 100 * numOfWashintuns;
            } if (totalCents >= 25)
            {
                numOfQuarters += totalCents / 25;
                totalCents -= 25 * numOfQuarters;
            }
            if (totalCents >= 10)
            {
                numOfDimeBags += totalCents / 10;
                totalCents -= 10 * numOfDimeBags;
            }
            if (totalCents >= 5)
            {
                numOfNickelSocks += totalCents / 5;
                totalCents -= 5 * numOfNickelSocks;
            }
            //the only remaining currency is pennies so i just set it equal to totalCents
            numOfPennies = totalCents;
            //writing the lines to show how many of each currency is in the amount called in the main function
            Console.WriteLine("Hundreds: " + numOfHunneds);
            Console.WriteLine("Fifties: " + numOfFiddys);
            Console.WriteLine("Twenties: " + numOfTwennes);
            Console.WriteLine("Tens: " + numOfTens);
            Console.WriteLine("Fives: " + numOfLincolns);
            Console.WriteLine("Ones: " + numOfWashintuns);
            Console.WriteLine("Quarters: " + numOfQuarters);
            Console.WriteLine("Dimes: " + numOfDimeBags);
            Console.WriteLine("Nickels: " + numOfNickelSocks);
            Console.WriteLine("Pennies: " + numOfPennies);
            
            
        }
    }
}
