using Notenverwaltung.Model;

namespace Notenverwaltung.Logik;

public class GymDurchschnittRechner : IDurchschnittRechner
{
    public double BerechnenDurchschnitt(IEnumerable<Zensur> zensuren)
    {
        double avgSA = 0;
        double avgLN = 0;
        int countSA = 0;
        int countLN = 0;
        double sumSA = 0;
        double sumLN = 0;

        foreach (Zensur z in zensuren)
        {
            if (z.Art == Leistungsart.SA)
            {
                sumSA += z.Note * 2;
                countSA += 2;
            }
            else
            {
                sumLN += z.Note;
                countLN++;
            }
        }

        if (countSA > 0)
        {
            avgSA = sumSA / countSA;
        }

        if (countLN > 0)
        {
            avgLN = sumLN / countLN;
        }

        if (countSA == 0 && countLN > 0) return Math.Round((double)avgLN, 2);
        if (countSA > 0 && countLN == 0) return Math.Round((double)avgSA, 2);
        if (countSA > 0 && countLN > 0) return Math.Round((avgSA + avgSA + avgLN) / 3, 2);
        return 0;
    }
   }
