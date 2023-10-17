using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Getraenkeverwaltung
{
	public class Punsch : Heissgetraenk
	{
		private double _alkoholgehalt;

		public double Alkoholgehalt
		{
			get { return _alkoholgehalt; }
			set { _alkoholgehalt = value; }
		}

	public Punsch(string bezeichnung, int fuellmenge, double temperatur, double alkoholgehalt) :
	base(bezeichnung, fuellmenge, temperatur)
		{
			Alkoholgehalt = alkoholgehalt;
		}

		public override string ToString()
		{
			return $"{base.ToString()} Alkoholgehalt: {Alkoholgehalt}% ";
		}
	}
}
