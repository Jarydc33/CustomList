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
            CustomList<int> list = new CustomList<int>();
            string myString;

            list.Add(1);
            list.Add(9);
            list.Add(2);
            list.Add(5);
            list.Add(6);
            list.Add(3);

            myString = list.ToString();
            Console.Write(list);
            

        }
    }
}
