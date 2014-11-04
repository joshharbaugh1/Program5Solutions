using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPickerv2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupPicker(20, 4);
            Console.ReadKey();
        }
        static void GroupPicker(int classSize, int groupSize)
        {
            //define variables
            Random randomNumberGenerator = new Random();
            //new list to hold individual students
            List<int> classList = new List<int>();
            List<int> groupList = new List<int>();
            //group counter
            int groupNumberCounter = 1;

            //fill our classList with an integer for
            //each student
            for (int i = 0; i <= classSize; i++)
            {
                //add a student number ot the classList
                classList.Add(i);
            }

            //fill groups until there are no more students to assign
            while (classList.Count() > 0)
            {
                //pick a random number
                int randomIndex = randomNumberGenerator.Next(0, classList.Count());
                //pick a random student
                int aStudent = classList[randomIndex];
                //remove the student from the class list
                classList.Remove(aStudent);
                //add the student to the group list
                groupList.Add(aStudent);

                //check to see if we should output the group
                if (groupList.Count() == groupSize || classList.Count() == 0)
                {
                    //do the output
                    Console.WriteLine("Group " + groupNumberCounter);
                    for (int i = 0; i < groupList.Count(); i++)
                    {
                        Console.Write(groupList[i] + " ");
                    }
                    //Console.WriteLine(string.Join(", ", groupList))
                    Console.WriteLine("\n");
                    //increment the groupNumberCounter
                    groupNumberCounter++;

                        //clear the groupList
                        groupList.Clear();
                }       
            }
        }
    }
}
