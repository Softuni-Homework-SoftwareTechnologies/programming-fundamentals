using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading numbers from console
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            // Print result
            Console.WriteLine("{0:0000} {1:0000} {2:0000} {3:0000}", num1, num2, num3, num4);
        }
    }
}
