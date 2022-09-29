// 29/09/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program pp = new Program();
            pp.Met1();

            Recurs(9);
        }

        public void Met1()
        {
            Console.WriteLine("I am an Object!");
        }

        static int Recurs(int x)
        {
            Console.WriteLine(x);
            if (x > 0) 
                Recurs(x - 1);
            return 0;
        }
    }
}
