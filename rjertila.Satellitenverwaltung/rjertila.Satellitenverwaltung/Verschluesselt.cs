using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rjertila.Satellitenverwaltung
{
	public class Verschluesselt : Sender
	{
		private string _verfahren = String.Empty;

		public string Verfahren
		{
			get { return _verfahren; }
			set { _verfahren = value; }
		}

		private string _paket = String.Empty;

		public string Paket
		{
			get { return _paket; }
			set { _paket = value; }
		}

		public Verschluesselt ( string name, string sprache, Qualiteaten qualitaet, string verfahren, string paket) : base(name, sprache, qualitaet)
		{
			Verfahren = verfahren;
			Paket = paket;
		}

		public override string ToString()
		{
			return $" {base.ToString()} ({Verfahren}) [{Paket}]";
		}

	}
}
