using System;
using System.Collections.Generic;

namespace GameCurrencySale;

class CurrencyPackage
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Coins { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var packages = new List<CurrencyPackage>
        {
            new CurrencyPackage { Id = 1, Name = "Starter Pack", Coins = 500, Price = 2.99m },
            new CurrencyPackage { Id = 2, Name = "Basic Pack", Coins = 1000, Price = 4.99m },
            new CurrencyPackage { Id = 3, Name = "Pro Pack", Coins = 2500, Price = 9.99m }
        };

        Console.WriteLine("================================");
        Console.WriteLine("      GAME CURRENCY SALE");
        Console.WriteLine("================================");

        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine() ?? "Guest";

        Console.WriteLine("\nAvailable Packages:");
        foreach (var package in packages)
        {
            Console.WriteLine($"{package.Id}. {package.Name} - {package.Coins} Coins - ${package.Price:F2}");
        }

        int packageChoice;
        while (true)
        {
            Console.Write("\nChoose package (1-3): ");
            if (int.TryParse(Console.ReadLine(), out packageChoice) &&
                packageChoice >= 1 && packageChoice <= packages.Count)
                break;

            Console.WriteLine("Invalid package. Please choose 1, 2, or 3.");
        }

        int quantity;
        while (true)
        {
            Console.Write("Enter quantity: ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                break;

            Console.WriteLine("Quantity must be greater than 0.");
        }

        CurrencyPackage selected = packages[packageChoice - 1];
        decimal total = selected.Price * quantity;

        Console.WriteLine("\n----------- SALE SUMMARY -----------");
        Console.WriteLine($"Customer : {customerName}");
        Console.WriteLine($"Package  : {selected.Name}");
        Console.WriteLine($"Coins    : {selected.Coins:N0} each");
        Console.WriteLine($"Quantity : {quantity}");
        Console.WriteLine($"Total    : ${total:F2}");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Thank you for your purchase!");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
