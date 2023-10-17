using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rjertila.Satellitenverwaltung
{
	public class Sender
	{
		private string _name = String.Empty;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private string _sprache = String.Empty;

		public string Sprache
		{
			get { return _sprache; }
			set { _sprache = value; }
		}

		private Qualiteaten _qualiteat;

		public Qualiteaten Qualiteat
		{
			get { return _qualiteat; }
			set { _qualiteat = value; }
		}


		public Sender(string name, string sprache, Qualiteaten qualiteat)
		{
			Name = name;
			Sprache = sprache;
			Qualiteat = qualiteat;
		}

		public override string ToString()
		{
			return $"{Name} {Sprache} {Qualiteat}";
		}
	}
}
