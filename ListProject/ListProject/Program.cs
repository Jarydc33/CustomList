using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list1 = new CustomList<int>();

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(2);
            list1.Add(4);
            list1.Add(6);
            list1.Add(8);
           

            //list1.Sort();
            Console.WriteLine(list1);
            Console.ReadLine();

        }
    }

    public class Test
    {
        public int score;
        public string name;

        public Test(int newScore, string myName)
        {
            score = newScore;
            name = myName;
        }
    }
}
