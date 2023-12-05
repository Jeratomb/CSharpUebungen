
using Notenverwaltung.Model;

namespace Notenverwaltung.Logik;

internal class StandardDurchschnittRechner : IDurchschnittRechner
{
    public double BerechnenDurchschnitt(IEnumerable<Zensur> zensuren)
    {
        double sum = 0;
        double count = 0;
        foreach (Zensur z in zensuren) 
        {
            if (z.Art == Leistungsart.SA) 
            { 
                sum += z.Note * 2; 
                count ++; 
            }
            else sum += z.Note; 
            count++;
        }
        return Math.Round(sum / count, 2);
    }
}
