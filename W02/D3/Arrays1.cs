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
            int[] numbers2 = new int[] { 21,52, 63, 884, 55, 26 };
            int[] numbers3 = new int[5];

            string [] numbers4;
            numbers4 = new string[5];
            numbers4[4] = "abc";

            for (int i = 0; i < numbers2.Length; i++)
                Console.WriteLine($"Element {i + 1} = {numbers2[i]}");

            Console.WriteLine(numbers2.Sum());
        }
    }
}

