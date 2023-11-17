using System;

public enum Food
{
    Fish,
    Mouse,
    DryFood
}

public class Cat
{
    private int hungerLevel; // Уровень сытости

    public int HungerLevel
    {
        get { return hungerLevel; }
    }

    public void EatSomething(Food food)
    {
        switch (food)
        {
            case Food.Fish:
                hungerLevel += 3;
                Console.WriteLine("The cat ate fish. Hunger level increased by 3.");
                break;

            case Food.Mouse:
                hungerLevel += 2;
                Console.WriteLine("The cat ate a mouse. Hunger level increased by 2.");
                break;

            case Food.DryFood:
                hungerLevel += 1;
                Console.WriteLine("The cat ate dry food. Hunger level increased by 1.");
                break;

            default:
                Console.WriteLine("Unknown food. Hunger level remains unchanged.");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Cat myCat = new Cat();

        Console.WriteLine($"Initial Hunger Level: {myCat.HungerLevel}");

        // Покормим кошку разными видами еды
        myCat.EatSomething(Food.Fish);
        Console.WriteLine($"Current Hunger Level: {myCat.HungerLevel}");

        myCat.EatSomething(Food.Mouse);
        Console.WriteLine($"Current Hunger Level: {myCat.HungerLevel}");

        myCat.EatSomething(Food.DryFood);
        Console.WriteLine($"Current Hunger Level: {myCat.HungerLevel}");

        myCat.EatSomething((Food)99); // Тестирование неизвестной еды
        Console.WriteLine($"Current Hunger Level: {myCat.HungerLevel}");
    }
}
