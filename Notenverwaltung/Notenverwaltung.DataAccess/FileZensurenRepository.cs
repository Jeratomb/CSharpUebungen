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
        if(_zensuren == null)
        {
           
        }
    }
}
