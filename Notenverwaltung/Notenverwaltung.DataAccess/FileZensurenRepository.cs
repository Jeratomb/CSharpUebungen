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
            var faecher = _zensuren.GroupBy(x => x.Fach).Select(y => y.First().Fach).OrderBy(z => z).ToList();

            using (FileStream fsDatei = File.Open(DateiPfad, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter writer = new StreamWriter(fsDatei, Encoding.UTF8))
                {
                    foreach(var fach in faecher) 
                    {
                        writer.WriteLine($"1:{fach}");
                        var zensurenFuerFach = _zensuren.Where(z => z.Fach == fach).OrderBy(z => z.Datum);
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

