using Notenverwaltung.Model;

namespace Notenverwaltung;


public interface IDurchschnittRechner
{
    double BerechnenDurchschnitt(IEnumerable<Zensur> zensuren);
}
