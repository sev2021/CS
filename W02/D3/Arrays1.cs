// 28/09/2022

using System;
using System.Linq;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare arrays

            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] numbers3 = new int[5];

            string [] numbers4;
            numbers4 = new string[5];
            numbers4[4] = "abc";

            Console.WriteLine(numbers4[2+2].Length + "\n");

            foreach (int i in numbers1) Console.WriteLine(i);
            foreach (string i in numbers4) Console.WriteLine(i);
        }
    }
}
