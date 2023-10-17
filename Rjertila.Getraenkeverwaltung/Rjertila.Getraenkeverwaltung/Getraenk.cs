using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Getraenkeverwaltung
{
	public class Getraenk
	{
		private string _bezeichnung = String.Empty;

		public string Bezeichnung
		{
			get { return _bezeichnung; }
			set { _bezeichnung = value; }
		}

		private int _fuellmenge;

		public int Fuellmenge
		{
			get { return _fuellmenge; }
			set { _fuellmenge = value; }
		}

		public Getraenk(string bezeichnung, int fuellmenge)
		{
			Bezeichnung = bezeichnung;
			Fuellmenge = fuellmenge;
		}

		public override string ToString()
		{
			return $"{Bezeichnung, -15} {Fuellmenge, -8}ml ";
		}

	}
}
