// 29/09/2022

using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            
            Greet(GetNane()); 

        }

        static void Greet(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }

        static string GetNane()
        {
            Console.WriteLine("Enter name:");
            string userName = Console.ReadLine();
            return userName;
        }
    }
}
