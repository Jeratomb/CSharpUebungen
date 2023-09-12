using rjertila.bmi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.BMI
{
	internal class Person
	{
		private string? _Nachname;

		public string? Nachname
		{
			get { return _Nachname; }
			set
			{
				if (value == null)
				{
					value = String.Empty;
				}
				_Nachname = value;
			}
		}

		private string? _Vorname;

		public string? Vorname
		{
			get { return _Vorname; }
			set
			{
				if (value == null)
				{
					value = String.Empty;
				}
				_Vorname = value;
			}
		}

		private Gender _Geschlecht;

		public Gender Geschlecht
		{
			get { return _Geschlecht; }
			set { _Geschlecht = value; }
		}


		private DateOnly _Geburtsdatum;

		public DateOnly Geburtsdatum
		{
			get { return _Geburtsdatum; }
			set { _Geburtsdatum = value; }
		}

		private double? _GewichtKg;

		public double? GewichtKg
		{
			get { return _GewichtKg; }
			set
			{
				if (value <= 0 && value >= 1000)
				{
					value = null;
				}
				_GewichtKg = value;
			}
		}

		private int? _GroesseCm;

		public int? GroesseCm
		{
			get { return _GroesseCm; }
			set
			{
				if (value <= 0 && value > 250)
				{
					value = null;
				}
				_GroesseCm = value;
			}
		}

		public Person(string nachname,string vorname, Gender geschlecht, DateOnly geburtsdatum )
		{
			Nachname = nachname;
			Vorname = vorname;
			Geschlecht = geschlecht;
			Geburtsdatum = geburtsdatum;
		}

		public Person()
		{
			Nachname = String.Empty;
			Vorname = String.Empty;
			Geschlecht = Gender.Male;
			Geburtsdatum = new DateOnly(1900,01,01);
			GroesseCm = null;
			GewichtKg = null;
		}

	}
}
