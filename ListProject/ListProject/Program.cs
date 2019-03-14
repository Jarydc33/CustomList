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

            CustomList<int> newList1 = new CustomList<int>();
            CustomList<int> newList2 = new CustomList<int>();
            CustomList<int> newList3 = new CustomList<int>();

            newList1.Add(1);
            newList1.Add(2);
            newList1.Add(3);
            newList1.Add(4);
            newList2.Add(2);
            newList2.Add(3);

            newList3 = newList1 - newList2;

            Console.WriteLine(newList3);
            Console.WriteLine(newList2);
            Console.WriteLine(newList1);
            Console.ReadLine();
        }
    }
}
