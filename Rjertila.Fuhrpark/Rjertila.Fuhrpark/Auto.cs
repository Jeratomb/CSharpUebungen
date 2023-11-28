using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Fuhrpark;
public class Auto
{
	public string Hersteller { get; set; }
	public string Typ { get; set; }
	public int Zulassungsjahr { get; set; }
	public double Listenpreis { get; set; }
	public int MaximaleGeschwindigkeit { get; set; }

	public double AktuelleGeschwindigkeit { get; protected set; }
	public int Reaktionsweg
	{
		get
		{

			double reaktionsweg = (this.AktuelleGeschwindigkeit / 10.0) * 3.0;
			return (int)Math.Ceiling(reaktionsweg);
		}
	}

	public int Bremsweg
	{
		get
		{
			double bremsweg = Math.Pow((this.AktuelleGeschwindigkeit / 10.0), 2);
			return (int)Math.Ceiling(bremsweg);
		}
	}

	public int Anhalteweg
	{
		get
		{
			return Reaktionsweg + Bremsweg;
		}
	}

	public Auto(string hersteller, string typ, int zulassungsjahr, double listenpreis, int maximaleGeschwindigkeit)
	{
		this.Hersteller = hersteller;
		this.Typ = typ;
		this.Zulassungsjahr = zulassungsjahr;
		this.Listenpreis = listenpreis;
		this.MaximaleGeschwindigkeit = maximaleGeschwindigkeit;
		this.AktuelleGeschwindigkeit = 0.0;
	}

	protected virtual double GetBeschleunigung()
	{
		return 6;
	}
	protected virtual double GetBremsbeschleunigung()
	{
		return 10;
	}

	public virtual void Beschleunigen(double dauerInSekunden)
	{
		if (dauerInSekunden != 0)
		{
			double speedInc = dauerInSekunden * GetBeschleunigung();
			if (this.AktuelleGeschwindigkeit + speedInc <= MaximaleGeschwindigkeit) this.AktuelleGeschwindigkeit += speedInc;
			else this.AktuelleGeschwindigkeit = MaximaleGeschwindigkeit;
		}else Console.WriteLine("Beschleunigungsdauer darf nicht 0 oder kleiner sein!");
    }

	public virtual void Bremsen(double dauerInSekunden)
	{
		if (dauerInSekunden != 0)
		{
			double speedDec = dauerInSekunden * GetBremsbeschleunigung();
			if (this.AktuelleGeschwindigkeit - speedDec >= 0) this.AktuelleGeschwindigkeit -= speedDec;
			else this.AktuelleGeschwindigkeit = 0;
		}	else Console.WriteLine("Bremsdauer darf nicht 0 oder kleiner sein!");
	}




	public virtual double BerechneWert(int Jahr)
	{
		int yearRange = Jahr - this.Zulassungsjahr;

		if (yearRange > 0)
		{
			double decRate = 12.0 / 100.0;
			double decValue = this.Listenpreis;
			for (int i = 0; i < yearRange; i++)
			{
				decValue -= decValue * decRate;
			}
			return Math.Ceiling(decValue);
		}
		else return this.Listenpreis;
	}

	public double BerechneWert()
	{
		int aktYear = DateTime.Now.Year;
		return BerechneWert(aktYear);
	}


}
