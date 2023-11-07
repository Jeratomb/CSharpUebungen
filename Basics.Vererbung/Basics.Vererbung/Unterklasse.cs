using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Vererbung
{
	internal class Unterklasse : Oberklasse
	{
		protected string _unterEigenschaft = String.Empty;

		public string UnterEigenschaft
		{
			get { return _unterEigenschaft; }
			set { _unterEigenschaft = value; }
		}
		public override void MacheEtwas()
		{
            Console.WriteLine(_unterEigenschaft);
            Console.WriteLine(_oberEigenschaft);
            Console.WriteLine("Ich arbeite in der Unterklasse");
			Console.WriteLine($"{OberEigenschaft} {UnterEigenschaft}");
		}
	}
}
