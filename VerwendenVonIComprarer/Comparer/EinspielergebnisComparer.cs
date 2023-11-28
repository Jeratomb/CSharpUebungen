using VerwendenVonIComparer.Model;

namespace VerwendenVonIComparer.Comparer;

public class EinspielergebnisComparer : IComparer<Film>
{
	public int Compare(Film? x, Film? y)
	{
		if(x != null || y != null)
		   return x.Einspielergebnis.CompareTo(y.Einspielergebnis);

		if (x == null || y != null) return 0;

		if (x != null || y == null) return 1;
    }

}
