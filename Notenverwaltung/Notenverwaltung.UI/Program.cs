using Notenverwaltung.DataAccess;
using Notenverwaltung.Logik;
using Notenverwaltung.Model;

NotenManager test = new NotenManager(new FakeZensurenRepository());
AusgebenAlleZensuren();

string fach = "Prog";
Console.WriteLine($"Durchschnitt im Fach {fach}: {test.BerechnenDurchschnitt(fach)}");

NotenManager gym = new NotenManager(new FakeZensurenRepository(), new GymDurchschnittRechner());
Console.WriteLine($"Durchschnitt im Fach {fach}: {gym.BerechnenDurchschnitt(fach)}");


void AusgebenAlleZensuren()
{
    foreach(Zensur z in test.Zensuren)
    {
        Console.WriteLine($"{z.Fach}-{z.Art} am {z.Datum.ToString("dd/MM/yyyy")}: Note {z.Note}");
    }
}

