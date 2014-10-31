using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupPicker(20, 5);
            Console.ReadKey();
        }

        static void GroupPicker(int ClassSize, int GroupSize)
        {
            List<int> ClassList = new List<int>();
            List<int> GroupList = new List<int>();
            Random rng = new Random();

            //loop through GroupSize and then add each integer to ClassList
            for (int i = 0; i < (GroupSize-1); i++)
			{
                GroupList.Add(i);
               
			}
            for (int i = 0; i < ClassSize; i++)
            {
                ClassList.Add(i);
            }
            while (ClassList.Count > 0)
            {
                int picker = rng.Next(0, ClassList.Count());
                int aStudent = ClassList[picker];
                GroupList.Add(aStudent);
                ClassList.RemoveAt(picker);
                //Console.WriteLine(aStudent);

                if (GroupList.Count() == GroupSize)
                {
                    Console.WriteLine("Group \n #{0} #{1} #{2} #{3} #{4}", GroupList[0], GroupList[1], GroupList[2], GroupList[3], GroupList[4]);
                    GroupList.Clear();
                    
                }
            }
        }
    }
}
