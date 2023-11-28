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
        IEnumerable<Zensur> data = new List<Zensur>();
        foreach(Zensur item in Zensuren)
        {
            if(item.Fach == fach) data.Append(item);
        }
        return data;
    }

    public double BerechnenDurchschnitt(string fach) 
    {

        IEnumerable<Zensur> zensurenFürFach = Zensuren.Where(z => z.Fach == fach);

        return zensurenFürFach.Any() ? BerechnenDurchschnitt(zensurenFürFach) : 0;
    }

    private double BerechnenDurchschnitt(IEnumerable<Zensur> zensurenFürFach)
    {
        throw new NotImplementedException();
    }

    public void HinzufuegenZensur(Zensur zensur)
    {
        _repository.Add(zensur);
        _repository.SaveChanges();
    }
}
