using Notenverwaltung.DataAccess;
using Notenverwaltung.Logik;
using Notenverwaltung.Model;
using System.Runtime.CompilerServices;

NotenManager test = new NotenManager(new FakeZensurenRepository());
AusgebenAlleZensuren();

string fach = "Prog";
Console.WriteLine($"Durchschnitt im Fach {fach}: {test.BerechnenDurchschnitt(fach)}");


void AusgebenAlleZensuren()
{
    foreach(Zensur z in test.Zensuren)
    {
        Console.WriteLine($"{z.Fach}-{z.Art} am {z.Datum}: Note {z.Note}");
    }
}

