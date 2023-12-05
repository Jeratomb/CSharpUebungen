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
    public NotenManager(IZensurenRepository repository, IDurchschnittRechner rechner)
    {
        _repository = repository;
        DurchschnittRechner = rechner;
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
        IEnumerable<Zensur> data = new List<Zensur>();
        foreach(Zensur item in Zensuren)
        {
            if (item.Fach == fach) data = data.Append(item);
        }
        return data;
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
