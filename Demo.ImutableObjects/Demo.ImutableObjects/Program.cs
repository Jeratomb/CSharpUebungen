// See https://aka.ms/new-console-template for more information
using Demo.ImutableObjects;

Console.WriteLine("Hello, World!");

var jetzt = DateTimeOffset.Now;
var messwert1 = new MesswertRecord(jetzt, 7.4 );
var messwert2 = new MesswertRecord(jetzt, 7.4 );
if(messwert1 == messwert2)
{
	Console.WriteLine("gleiche Daten");
}
else
{
	Console.WriteLine("unterschiedliche Daten");
}
Console.WriteLine($"Zeitpunkt: {messwert1.Zeitpunkt}, Temperatur {messwert1.Temperatur}");
// hier können die Eigenschaften NACH der Erstellung des Objekts
// nicht mehr verändert werden..
//messwert1.Zeitpunkt = DateTimeOffset.Now;
//messwert1.Temperatur = 20;
