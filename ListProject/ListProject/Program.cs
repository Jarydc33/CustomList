using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class Program
    {
        static void Main()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> result = new CustomList<string>();
            list1.Add("Jaryd");
            list1.Add("the");
            list1.Add("person");
            list1.Add("you");
            list1.Add("know");
            list2.Add("is");
            list2.Add("best");
            list2.Add("that");
            result = CustomList<string>.Zip(list1,list2);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
