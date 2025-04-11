// File: FoodApp.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        AskAboutFood();
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Food App!");
    }

    static void AskAboutFood()
    {
        Console.Write("What is your favorite food? ");
        string favoriteFood = Console.ReadLine();

        Console.Write("How often do you eat it (e.g., daily, weekly)? ");
        string frequency = Console.ReadLine();

        DisplayFoodInfo(favoriteFood, frequency);
    }

    static void DisplayFoodInfo(string food, string frequency)
    {
        Console.WriteLine($"\nYum! You like {food} and eat it {frequency}.");
        Console.WriteLine("Thanks for sharing!");
    }
}
