using System;

class CharacterStats
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        string health = new string('|', currentHealth);
        string energy = new string('|', currentEnergy);
        string missingHealth = new string('.', maxHealth - currentHealth);
        string missingEnergy = new string('.', maxEnergy - currentEnergy);

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: |{health}{missingHealth}|");
        Console.WriteLine($"Energy: |{energy}{missingEnergy}|");
    }
}