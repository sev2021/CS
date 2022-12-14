// 28/09/2022

{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //////////////////////////// SORT
            Array.Sort(weekDays);
            foreach (string day in weekDays) Console.WriteLine(day);
            
            Console.WriteLine("_______________");

            ///////////////////////////  REVERSE
            Array.Reverse(weekDays);
            foreach (string day in weekDays) Console.WriteLine(day);

            Console.WriteLine("_______________");

            ///////////////////////////////// RESIZE
            Array.Resize(ref weekDays, 12);
            foreach (string day in weekDays) Console.WriteLine(day);

            Console.WriteLine("_______________");

            /////////////////////////////////// CLEAR 
            Array.Clear(weekDays, 2, 3);    /// <array>, <start index> , <number of elements>
            foreach (string day in weekDays) Console.WriteLine(day);

            Console.WriteLine("_______________");
            
            //////////////////////////// FOREACH
            Array.ForEach(weekDays, x => Console.WriteLine(x));

            Console.WriteLine("_______________");

            //////////////////////////// COPY
            
            string[] weekD = new string[4];

            Array.Copy(weekDays, weekD, 3);
            foreach (string day in weekD) Console.WriteLine(day);

            Console.WriteLine("_______________");

            
        }
    }
}
