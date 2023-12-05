
using Notenverwaltung.Model;

namespace Notenverwaltung.Logik;

internal class StandardDurchschnittRechner : IDurchschnittRechner
{
    public double BerechnenDurchschnitt(IEnumerable<Zensur> zensuren)
    {
        int sum = 0;
        int count = 0;
        foreach (Zensur z in zensuren) 
        {
            if (z.Art == Leistungsart.SA) 
            { 
                sum += z.Note * 2; 
                count ++; 
            }
            else sum += z.Note; count++;
        }
        return Math.Round((double)sum / (double)count, 2);
    }
}
