// File: CarApp.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        AskAboutCar();
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Car App!");
    }

    static void AskAboutCar()
    {
        Console.Write("What is your favorite car brand? ");
        string carBrand = Console.ReadLine();

        Console.Write("What model do you like the most? ");
        string carModel = Console.ReadLine();

        DisplayCarInfo(carBrand, carModel);
    }

    static void DisplayCarInfo(string brand, string model)
    {
        Console.WriteLine($"\nNice choice! You like the {brand} {model}.");
        Console.WriteLine("Drive safe!");
    }
}
