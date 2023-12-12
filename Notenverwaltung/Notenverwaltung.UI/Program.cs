using Notenverwaltung.DataAccess;
using Notenverwaltung.Logik;
using Notenverwaltung.Model;
using System;

class Program
{
    static void Main()
    {
        FileZensurenRepository repo = new FileZensurenRepository("H:\\MeinNoten.txt");

        NotenManager notenManager = new NotenManager(repo);

        AusgebenAlleZensuren(notenManager);

        string fach = "Prog";
        Console.WriteLine($"Durchschnitt im Fach {fach}: {notenManager.BerechnenDurchschnitt(fach)}");

        notenManager.DurchschnittRechner = new GymDurchschnittRechner();
        Console.WriteLine($"Durchschnitt im Fach {fach}: {notenManager.BerechnenDurchschnitt(fach)}");

        Zensur testZensur = new Zensur("Meso", new DateTime(2023, 12, 05), 4, Leistungsart.KA);
        Zensur testZensur2 = new Zensur("Meso", new DateTime(2022, 12, 05), 4, Leistungsart.KA);
        Zensur testZensur3 = new Zensur("Meso", new DateTime(2021, 12, 05), 4, Leistungsart.KA);
        notenManager.HinzufuegenZensur(testZensur);
        notenManager.HinzufuegenZensur(testZensur2);
        notenManager.HinzufuegenZensur(testZensur3);

    }

    static void AusgebenAlleZensuren(NotenManager notenManager)
    {
        foreach (Zensur z in notenManager.Zensuren)
        {
            Console.WriteLine($"{z.Fach}-{z.Art} am {z.Datum.ToString("dd/MM/yyyy")}: Note {z.Note}");
        }
    }
}
