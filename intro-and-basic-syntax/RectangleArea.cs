using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        // First we get the input for width and we parse it making it into a type double.
        double wid = double.Parse(Console.ReadLine());
        // We do the same thing for the height with again type double.
        double hei = double.Parse(Console.ReadLine());
        //Then we create a new double variable which will be the calculation between the width multiplied by the height.
        double ar = wid * hei;
        //Finally we print the area variable with $"{area:F2}" so the outcome will be formatted to the 2nd character after the decimal point.
        Console.WriteLine($"{ar:F2}");
    }
}