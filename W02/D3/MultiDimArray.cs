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

            // BEWARE IT IS COMPLETELY DIFFERENT THAN JAVA
            // SUB-ARRAY SIZE F-I-X-E-D !!
            
            int[,] darray = new int[2,5] { { 2, 4, 8, 16, 32 }, { 55, 66, 77, 88 ,99} };


            Console.WriteLine(darray[1,2]);


        }
    }
}
