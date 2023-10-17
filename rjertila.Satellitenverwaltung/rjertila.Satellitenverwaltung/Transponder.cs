using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rjertila.Satellitenverwaltung
{
	public class Transponder
	{
		private int _nr;

		public int Nr
		{
			get { return _nr; }
			set { _nr = value; }
		}
		private Polarisationen _polarisation;

		public Polarisationen Polarisation
		{
			get { return _polarisation; }
			set { _polarisation = value; }
		}
		private int _frequenz;

		public int Frequenz
		{
			get { return _frequenz; }
			set { _frequenz = value; }
		}
		private List<Sender> _sender;
			
		public List<Sender> Sender
		{
			get { return _sender; }
			set { _sender = value; }
		}

		public Transponder(int nr, Polarisationen polarisation, int frequenz, List<Sender> sender)
		{
			Nr = nr;
			Polarisation = polarisation;
			Frequenz = frequenz;
			Sender = sender;
		}

		public override string ToString()
		{
			return $"Nr: {Nr}, Polarisation: {Polarisation}, Frequenz: {Frequenz}";
		}




	}
}
