using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypesReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = x;
            //x = 25;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.ReadLine();


            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            Console.ReadLine();

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            Console.ReadLine();
        }
    }
}
