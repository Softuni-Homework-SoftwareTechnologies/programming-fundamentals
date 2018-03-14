//CONFIRMED from VTheodore
using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading parameters from console
            var product = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            // Calculations
            double totalEnergy = energyPer100ml / 100.0 * volume;
            double totalSugars = sugarPer100ml * volume / 100.0;

            // Print result
            Console.WriteLine("{0}ml {1}:", volume, product);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugars);
        }
    }
}
