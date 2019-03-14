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
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();

            list1.Add("JAryd.");
            list1.Add("3");
            list1.Add("5");
            list1.Add("7");
            list2.Add("3");
            list2.Add("4");
            list2.Add("JAryd");
            list2.Add("JAryd");
            list2.Add("JAryd");
            list2.Add("JAryd");
            list2.Add("JAryd");
            list2.Add("JAryd");

            result = list1.Zip(list2);

            Console.WriteLine(result);
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
