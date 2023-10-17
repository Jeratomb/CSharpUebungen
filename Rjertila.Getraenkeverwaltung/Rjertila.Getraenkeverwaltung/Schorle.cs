using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Getraenkeverwaltung
{
	public class Schorle : Kaltgetraenk
	{
		private double _wasseranteil;

		public double Wasseranteil
		{
			get { return _wasseranteil; }
			set { _wasseranteil = value; }
		}

		public Schorle(string bezeichnung, int fuellmenge, int eiswuerfel, double wasseranteil) :
			base(bezeichnung, fuellmenge, eiswuerfel)
		{
			Wasseranteil = wasseranteil;
		}

		public override string ToString()
		{
			return $"{base.ToString()}  Wasseranteil: {Wasseranteil}";	
		}
	}
}
