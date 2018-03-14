using System;

class CharacterStats
{
    static void Main(string[] args)
    {
        // First we get the input from the console which contains the name we store it in string variable
        string name = Console.ReadLine();
        // We get the currentHealth from the console and we parse it into a int variable the same thing is repeated for all of the next inputs
        int currentHealth = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        // Creating string health which contains | for as much as the value of currentHealth is.
        string health = new string('|', currentHealth);
        // The same thing but this time for the value of currentEnergy.
        string energy = new string('|', currentEnergy);
        // Now we subtract currentHealth from maxHealth 
        string missingHealth = new string('.', maxHealth - currentHealth);
        // Then we subtract currentEnergy from maxEnergy
        string missingEnergy = new string('.', maxEnergy - currentEnergy);

        // Finally We print the outcomes name,health,missingHealth,energy and missingEnergy
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: |{health}{missingHealth}|");
        Console.WriteLine($"Energy: |{energy}{missingEnergy}|");
    }
}