using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Josh";
            int myAge = 20;
            bool myBool = true;
            List<string> productsList = new List<string>() { "basketball", "baseball glove", "tennis shoes", "hockey puck" };
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            Console.WriteLine("I am " + myAge + " years awesome.");
            Console.WriteLine("I set my boolean value equal to " + myBool);
            //loop through the productsList
            for (int i = 0; i < productsList.Count(); i++)
            {
                Console.WriteLine(productsList[i]);
                   
            }
            //loop through i starting at 1 and going through 10
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            //loop through i starting at 10 and going down to 1
            for (int i = 11; i < 1; i--)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i < 31; i+= 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 100; i > 74; i-= 5)
            {
                Console.WriteLine(i);
            }
            //calling all functions here
            WhileLoopPractice();
            WhileLoopPractice1();
            WhileLoopPractice2();
            WhileLoopPractice3();
            WhileLoopPractice4(myBool);
            PuttingItTogether(myName);
            PuttingItTogether1(productsList.Count());
            PuttingItTogether2(productsList);
            Greeting("Beef Hardchest");
            Greeting(myName);
            DoubleIt(1337);
            DoubleIt(myAge);
            Multiply(2, 8);
            Multiply(3, myAge);
            LoopThis(20, 30);
            LoopThis(0, myAge);
            SuperLoop(0, 100, 15);
            SuperLoop(0, 200, myAge);
            Console.WriteLine(NewGreeting("Neil deGrasse-Tyson"));
            Console.WriteLine(NewGreeting(myName));
            Console.WriteLine("10 tripled is " + TripleIt(10));
            Console.WriteLine(myAge + " tripled is " + TripleIt(myAge));
            Console.WriteLine(RealMultiply(5, 10));
            Console.WriteLine(RealMultiply(2, myAge));
            SuperLoop(RealMultiply(1, 5), TripleIt(myAge), TripleIt(myAge - 10));
            SuperLoop(RealMultiply(1,TripleIt(3)), TripleIt(RealMultiply(myAge,7)), TripleIt(myAge-RealMultiply(2,4)));
            
            Console.ReadKey();
        }

        //while loop starting at 1 and counting up to 10
        static void WhileLoopPractice()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
 
        }
        //while loop starting at 10 and counting down to 1
        static void WhileLoopPractice1()
        {
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i = i - 1;
            }
        }
        static void WhileLoopPractice2()
        {
            int i = 16;
            while (i <= 30)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
        static void WhileLoopPractice3()
        {
            int i = 100;
            while (i >= 75)
            {
                Console.WriteLine(i);
                i = i - 5;
            }
        }
        //a while loop checking whether a number is 
        //divisible by 4 and stopping when it reaches that number
        static void WhileLoopPractice4(bool myBool)
        {
            
            while (myBool)
            {
                for (int i = 1; i < 11; i = i + 1)
                {
                    if (i % 4 == 0)
                    {
                        myBool = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        //a function that extracts the number of letters
        //in the myName variable
        static void PuttingItTogether(string myName)
        {
            int numberOfLetters = myName.Length;
            Console.WriteLine("My name, " + myName + ",has " + numberOfLetters + " in it.");

        }
        //a function that shows how many items are in the 
        //products list variable
        static void PuttingItTogether1(int number)
        {
            
            Console.WriteLine("My product list has " + number + " in it.");
        }
        //a function that shows how many characters are in
        //each item on the list while putting each on a seperate line
        static void PuttingItTogether2(List<string> list)
        {
            for (int i = 0; i < list.Count(); i = i + 1)
            {
                Console.WriteLine(list[i] + " has " + list[i].Length + " in it.");
            }
        }
        //a function that prints "Hello" and your name to the console
        static string Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        //a function that calculates the variable "myAge" and doubles it
        static void DoubleIt(int number)
        {
            Console.WriteLine(number + " doubled is " + number * 2);
        }
        //a function that multiplies manually entered numbers by themselves
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + num1 * num2);
        }
        //This loop counts to 100 incrementing by 
        //15 each time
        static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
            for (int i = startNum; i <= endNum; i = i + 1)
            {
                Console.WriteLine(i);
            }   
        }
        //SuperLoop counts to a certain number by increments
        //that the user inputs and is later called upon
        //for the rest of the other loops
        static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = increment;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + " incrementing " + increment + " each time");
            for (int i = startNum; i <= endNum; i += increment)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("That loop was craaaaaaazy, we looped " + (((endNum - startNum)/increment) + 1) + " times");
        }
        static string NewGreeting(string name)
        {
            return "Hello, " + name;
        }
        static int TripleIt(int number)
        {
            return number * 3;
        }
        static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
