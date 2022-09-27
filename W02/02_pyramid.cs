// Week01 Day02 pyramid exercise
// using string.PadLeft(<number>, <char>) option

using System;

namespace ForLoop1
{
    internal class Fibonacci
    {
        static void Main()
        {
            //declare variable
            int row, col;

            for (row = 1; row < 25; row++)
            {
                Console.WriteLine("".PadLeft((row + row - 1), 'X').PadLeft((26 + row), ' '));
            }
        }
    }
}
