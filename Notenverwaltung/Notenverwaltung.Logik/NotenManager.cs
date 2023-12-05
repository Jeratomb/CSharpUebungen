using Notenverwaltung.DataAccess;
using Notenverwaltung.Model;

namespace Notenverwaltung.Logik;

public class NotenManager
{   
    private readonly IZensurenRepository _repository;
    public IDurchschnittRechner DurchschnittRechner { get; set; }
    public NotenManager(IZensurenRepository repository)
    {
        _repository = repository;
        DurchschnittRechner = new StandardDurchschnittRechner();
    }

    public IEnumerable<Zensur> Zensuren
    {
        get
        {
            return _repository.GetAll();
        }
    }

    public IEnumerable<Zensur> ZensurenImFach(string fach)
    {
        //List<Zensur> data = new List<Zensur>();
        // data.Add(item)
        foreach (Zensur item in Zensuren)
        {
            if (item.Fach.Equals(fach)) yield return item;
        }
    }

    public double BerechnenDurchschnitt(string fach) 
    {

        // IEnumerable<Zensur> zensurenFürFach = Zensuren.Where(z => z.Fach == fach);

        IEnumerable<Zensur> zensurenFürFach = ZensurenImFach(fach);

        return zensurenFürFach.Any() ? DurchschnittRechner.BerechnenDurchschnitt(zensurenFürFach) : 0;
    }

    public void HinzufuegenZensur(Zensur zensur)
    {
        _repository.Add(zensur);
        _repository.SaveChanges();
    }
}
