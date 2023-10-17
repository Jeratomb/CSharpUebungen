using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Getraenkeverwaltung
{
	public class Kaltgetraenk : Getraenk
	{
		private int _eiswuerfel;

		public int Eiswuerfel
		{
			get { return _eiswuerfel; }
			set { _eiswuerfel = value; }
		}

		public Kaltgetraenk(string bezeichnung, int fuellmenge, int eiswuerfel) :
			base(bezeichnung, fuellmenge)
		{
			Eiswuerfel = eiswuerfel;
		}

		public override string ToString()
		{
			return $"{base.ToString()}  Eiswuerfel: {Eiswuerfel} ";
		}

	}
}
