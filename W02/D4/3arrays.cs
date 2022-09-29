// 29/09/2022

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
            // declare variables
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int[] a1 = { 5, 6, 9 };
            int[] a2 = { 8, 6, 5 };
            int[] aRes = new int[2];

            int resIndex = 0;

            //////////////////////////// looping first array
            foreach(int n1 in a1)
            {
                int rep = 0;
                foreach (int n2 in a2)
                {
                    if (n1 == n2) rep++;
                }
                if(rep == 0)
                {
                    aRes[resIndex] = n1;
                    resIndex++;
                    break;
                }
            }

            //////////////////////////// looping 2nd array
            foreach (int n2 in a2)
            {
                int rep = 0;
                foreach (int n1 in a1)
                {
                    if (n1 == n2) rep++;
                }
                if (rep == 0)
                {
                    aRes[resIndex] = n2;
                    break;
                }
            }


            ///////////////////////////// printing result array
            foreach (int i in aRes) Console.WriteLine(i);
        }
    }
}
