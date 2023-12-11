using Notenverwaltung.Model;
using System.Globalization;
using System.Text;

namespace Notenverwaltung.DataAccess;

public class FileZensurenRepository : IZensurenRepository
{
    private readonly string DateiPfad;
    public List<Zensur> _zensuren;
    public FileZensurenRepository(string dateiPfad)
    {
        DateiPfad = dateiPfad;
    }

    public IEnumerable<Zensur> GetAll()
    {
        string currentSubject = "";
        if (_zensuren == null)
        {
            _zensuren = new List<Zensur>();

            foreach (var line in File.ReadLines(DateiPfad, Encoding.UTF8))
            {
                try
                {
                    int index = int.Parse(line.Substring(0, 1));
                    if (index == 1)
                    {
                        currentSubject = line.Substring(2);
                    }
                    if (index == 2)
                    {
                        DateTime date;
                        DateTime.TryParseExact(line.Substring(2, 8), "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
                        Leistungsart art;
                        Enum.TryParse<Leistungsart>(line.Substring(10, 3).Trim(), true, out art);
                        int note = int.Parse(line.Substring(13).Trim());
                        _zensuren.Add(new Zensur(currentSubject, date, note, art));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }
        Console.WriteLine("Successfull");
        return _zensuren ?? Enumerable.Empty<Zensur>();
    }

    public void Add(Zensur zensur)
    {
        _zensuren.Add(zensur);
    }

    public void SaveChanges()
    {
        if (_zensuren != null)
        {
            //var faecher = _zensuren.GroupBy(x => x.Fach).Select(y => y.First().Fach).OrderBy(z => z).ToList();
            List<string> faecher = new();
            HashSet<string> faecherSet = new();

            foreach(var item in _zensuren)
            {
                if(faecherSet.Add(item.Fach))
                {
                    faecher.Add(item.Fach);
                }
            }
            faecher.Sort();

            using (FileStream fsDatei = File.Open(DateiPfad, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter writer = new StreamWriter(fsDatei, Encoding.UTF8))
                {
                    foreach(var fach in faecher) 
                    {
                        writer.WriteLine($"1:{fach}");
                        List<Zensur> zensurenFuerFach = new();
                        foreach(var item in _zensuren)
                        {
                            if(item.Fach == fach)
                            {
                                zensurenFuerFach.Add(item);
                               
                            }
                        }

                        for (int i = 0; i < zensurenFuerFach.Count - 1; i++)
                        {
                            for (int j = 0; j < zensurenFuerFach.Count - i - 1; j++)
                            {
                                if (zensurenFuerFach[j].Datum > zensurenFuerFach[j + 1].Datum)
                                {
                                    
                                    Zensur temp = zensurenFuerFach[j];
                                    zensurenFuerFach[j] = zensurenFuerFach[j + 1];
                                    zensurenFuerFach[j + 1] = temp;
                                }
                            }
                        }
                        foreach (var item in zensurenFuerFach)
                        {
                            writer.WriteLine(item.FormatZensur());
                        }
                    }
                }
            }
            Console.WriteLine("Successfull");
        }
    }
}

