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

            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            string toDay = DateTime.Now.DayOfWeek.ToString();

            // foreach (string day in weekDays) Console.WriteLine(toDay == day ? "TODAY" : day);
            int i = -1;
            while (++i < weekDays.Length)
            {
                Console.WriteLine(weekDays[i] == toDay ? "T-O-D-A-Y" : weekDays[i]);
            }

        }
    }
}
