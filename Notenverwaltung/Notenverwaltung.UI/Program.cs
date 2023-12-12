using Notenverwaltung.DataAccess;
using Notenverwaltung.Logik;
using Notenverwaltung.Model;
using System;

class Program
{
    static void Main()
    {
        FileZensurenRepository repo = new FileZensurenRepository("X:\\FilesForCode\\MeinNoten.txt");

        NotenManager notenManager = new NotenManager(repo);

        AusgebenAlleZensuren(notenManager);

        string fach = "Prog";
        Console.WriteLine($"Durchschnitt im Fach {fach}: {notenManager.BerechnenDurchschnitt(fach)}");

        notenManager.DurchschnittRechner = new GymDurchschnittRechner();
        Console.WriteLine($"Durchschnitt im Fach {fach}: {notenManager.BerechnenDurchschnitt(fach)}");

        Zensur testZensur = new Zensur("Meso", new DateTime(2023, 12, 05), 4, Leistungsart.KA);
        notenManager.HinzufuegenZensur(testZensur);
    }

    static void AusgebenAlleZensuren(NotenManager notenManager)
    {
        foreach (Zensur z in notenManager.Zensuren)
        {
            Console.WriteLine($"{z.Fach}-{z.Art} am {z.Datum.ToString("dd/MM/yyyy")}: Note {z.Note}");
        }
    }
}
