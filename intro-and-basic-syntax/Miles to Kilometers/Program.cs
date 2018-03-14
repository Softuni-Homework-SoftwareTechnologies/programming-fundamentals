using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
			//Reading a floating point number from the Console
            double miles = double.Parse(Console.ReadLine());
			//To find the distance in kilometres the distance in miles is multiplied by 1.60934 => 1 mile == 1.60934
			//To be even more precise we use the data type 'double'
            double km = miles * 1.60934;
			//And finally the result is formated to the 2nd decimal place.
            Console.WriteLine("{0:f2}", km);
        }
    }
}
