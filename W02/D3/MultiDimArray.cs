// 28/09/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StringArrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] darray = new int[2, 5] { { 2, 4, 8, 16, 32 }, { 55, 66, 77, 88, 99 } };
            Console.WriteLine(darray[1, 2]);
            Console.WriteLine(darray.Rank);

            int[] aa = { 22, 55, 22, 66, 11 };

            Array.Sort(aa);
            foreach (int i in aa) Console.WriteLine(i);


            Console.WriteLine("------------------");
            Console.WriteLine(Array.Find(aa, e => e > 33));

        }
    }
}

