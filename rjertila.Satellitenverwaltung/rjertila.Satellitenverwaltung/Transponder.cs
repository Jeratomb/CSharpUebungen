using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rjertila.Satellitenverwaltung
{
	public class Transponder
	{
		private int _nr = 0;

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
		private int _frequenz = 0;

		public int Frequenz
		{
			get { return _frequenz; }
			set { _frequenz = value; }
		}	
		public List<Sender> Sender { get; }

		public Transponder(int nr, Polarisationen polarisation, int frequenz)
		{
			Nr = nr;
			Polarisation = polarisation;
			Frequenz = frequenz;
			Sender = new();
		}

		public override string ToString()
		{
			string output = $"Nr: {Nr}, Polarisation: {Polarisation}, Frequenz: {Frequenz}";
			output += Environment.NewLine;
			foreach (Sender sender in Sender) 
			{
				output += sender.ToString() ;
				output += Environment.NewLine;
			}
			return output;
		}




	}
}
