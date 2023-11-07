using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Fuhrpark;

	public class Cabrio : Auto
	{
	public bool IstVerdeckOffen { get; private set; }

	public Cabrio(string hersteller, string typ, int zulassungsjahr, double listenpreis, int maximaleGeschwindigkeit, bool istVerdeckOffen)
			: base(hersteller, typ, zulassungsjahr, listenpreis, maximaleGeschwindigkeit)
	{
		this.IstVerdeckOffen = istVerdeckOffen;
	}

	public void OeffnenVerdeck()
	{
		IstVerdeckOffen = true;
	}

	public void SchliessenVerdeck()
	{
		IstVerdeckOffen = false;
	}
	protected override double GetBeschleunigung()
	{

		return 4;
	}

	protected override double GetBremsbeschleunigung()
	{

		return 7;
	}

	public override double BerechneWert(int Jahr)
	{
		double decreaseRate;
		double decValue = this.Listenpreis;
		int yearRange = Jahr - this.Zulassungsjahr;

		if (yearRange <= 0)
		{
			return this.Listenpreis;
		}
		else if (yearRange <= 10)
		{
			decreaseRate = 0.08; 
			
			for (int i = 0; i < yearRange; i++)
			{
				decValue -= decValue * decreaseRate;
			}
			return Math.Ceiling(decValue);
		}
		else if (yearRange <= 20)
		{
			decreaseRate = 0.06; 
			for (int i = 0; i < yearRange; i++)
			{
				decValue -= decValue * decreaseRate;
			}
			return Math.Ceiling(decValue);
		}
		else
		{
			return this.Listenpreis; 
		}
	}
}

