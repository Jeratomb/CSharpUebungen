using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Getraenkeverwaltung
{
	public class Heissgetraenk : Getraenk
	{
		private double _temperatur;

		public double Temperatur
		{
			get { return _temperatur; }
			set { _temperatur = value; }
		}

		public Heissgetraenk(string bezeichnung, int fuellmenge, double temperatur) :
			base(bezeichnung, fuellmenge)
		{
			Temperatur = temperatur;
		}

		public override string ToString()
		{
			return $"{base.ToString()} Temperatur: {Temperatur}C°";
		}
	}
}
