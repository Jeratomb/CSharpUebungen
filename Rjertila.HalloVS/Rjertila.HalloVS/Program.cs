// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Bitte gib deinen Namen ein");
string vorname = Console.ReadLine()?? String.Empty;
Console.WriteLine($"Hallo {vorname}, schön, dass du C# programmierst");
Console.WriteLine("Was ist deine (ganze) Lieblingszahl?");
int favZahl = int.Parse(Console.ReadLine()?? String.Empty);
Console.WriteLine("Deine Lieblingszahl ist {0}",favZahl);