using Notenverwaltung.Model;

namespace Notenverwaltung.DataAccess;

public class FileZensurenRepository
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
            string[] lines = File.ReadAllLines(DateiPfad);
            foreach (string line in lines)
            {
                int index = int.Parse(line.Substring(0, 1));
                if(index == 1)
                {
                    currentSubject = line.Substring(2);
                }
                if(index == 2)
                {
                    DateTime date = DateTime.Parse(line.Substring(2, 8));
                    Leistungsart art;
                    Enum.TryParse<Leistungsart>(line.Substring(10, 2).Trim(), true, out art);
                    int note = int.Parse(line.Substring(13));
                    _zensuren.Add(new Zensur(currentSubject, date, note, art));
                    // TODO: testing if its working
                }
            }
        }
        return _zensuren;
        
    }
}
