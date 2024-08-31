// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentdate= DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentdate:d}");
Console.WriteLine($"{Environment.NewLine}Press any key to exit....");
Console.ReadKey(true);
