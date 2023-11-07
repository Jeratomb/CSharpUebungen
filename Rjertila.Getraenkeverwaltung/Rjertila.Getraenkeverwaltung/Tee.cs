using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Getraenkeverwaltung
{
	public class Tee : Heissgetraenk
	{
		private int _ziehzeit;

		public int Ziehzeit
		{
			get { return _ziehzeit; }
			set { _ziehzeit = value; }
		}

		public Tee(string bezeichnung, int fuellmenge, double temperatur,int ziehzeit) :
			base(bezeichnung, fuellmenge,temperatur)
		{
			Ziehzeit = ziehzeit;
		}

		public override string ToString()
		{
			return $"{base.ToString()}  Ziehzeit: {Ziehzeit}";
		}
	}
}
