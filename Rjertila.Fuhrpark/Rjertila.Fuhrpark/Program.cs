using System;

namespace Rjertila.Fuhrpark
{
	class Program
	{
		static void BeschleunigungsTest(Cabrio cabrio)
		{
			Console.WriteLine($"Aktuelle Geschwindigkeit des Cabrios: {cabrio.AktuelleGeschwindigkeit} km/h");
			cabrio.Beschleunigen(10);
			Console.WriteLine("Beschleunigen für 10 Sekunden");
			Console.WriteLine($"Aktuelle Geschwindigkeit des Cabrios nach Beschleunigung: {cabrio.AktuelleGeschwindigkeit} km/h");
		}

		static void BremsenTest(Cabrio cabrio)
		{
			cabrio.Bremsen(5);
			Console.WriteLine($"Aktuelle Geschwindigkeit des Cabrios nach Bremsen: {cabrio.AktuelleGeschwindigkeit} km/h");
		}

		static void VerdeckTest(Cabrio cabrio)
		{
			cabrio.OeffnenVerdeck();
			Console.WriteLine($"Ist das Verdeck des Cabrios geöffnet? {cabrio.IstVerdeckOffen}");

			cabrio.SchliessenVerdeck();
			Console.WriteLine($"Ist das Verdeck des Cabrios geschlossen? {cabrio.IstVerdeckOffen}");
		}

		static void WertBerechnungTest(Cabrio cabrio)
		{
			double wert = cabrio.BerechneWert(2023);
			Console.WriteLine($"Wert des Cabrios im Jahr 2023: {wert}€");
		}

		static void BeschleunigungsTest(Auto auto)
		{
			auto.Beschleunigen(10);
			Console.WriteLine($"Aktuelle Geschwindigkeit des Autos nach Beschleunigung: {auto.AktuelleGeschwindigkeit} km/h");
		}

		static void BremsenTest(Auto auto)
		{
			auto.Bremsen(5);
			Console.WriteLine($"Aktuelle Geschwindigkeit des Autos nach Bremsen: {auto.AktuelleGeschwindigkeit} km/h");
		}

		static void WertBerechnungTest(Auto auto)
		{
			double autoWert = auto.BerechneWert(2021);
			Console.WriteLine($"Wert des Autos im Jahr 2021: {autoWert}€");
		}

		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			Cabrio cabrio = new Cabrio("Hersteller", "Cabrio", 2020, 50000, 200, false);
			BeschleunigungsTest(cabrio);
			BremsenTest(cabrio);
			VerdeckTest(cabrio);
			WertBerechnungTest(cabrio);

			Auto auto = new Auto("Hersteller", "Auto", 2019, 50000, 180);
			BeschleunigungsTest(auto);
			BremsenTest(auto);
			WertBerechnungTest(auto);
		}

	}
}
