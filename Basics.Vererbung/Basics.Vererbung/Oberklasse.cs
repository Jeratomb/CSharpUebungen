using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Vererbung
{
	internal class Oberklasse
	{

		protected string _oberEigenschaft = String.Empty;
		public string OberEigenschaft
		{
			get { return _oberEigenschaft; }
			set { _oberEigenschaft = value; }
		}

		public virtual void MacheEtwas()
		{
			Console.WriteLine("Ich mache etwas in der Oberklasse");
			Console.WriteLine($"Obereigenschaft: {OberEigenschaft}");
		}
	}
}
