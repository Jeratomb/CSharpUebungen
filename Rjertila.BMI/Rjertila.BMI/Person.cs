using rjertila.bmi;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.BMI
{
	internal class Person
	{
		#region Propfulls

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
		#endregion

		#region GetOnlyProps
		private string VollerName
		{
			get { return Vorname + Nachname; }
		}

		private int AktuellesAlter
		{
			get { return BerechneAlter(DateOnly.FromDateTime(DateTime.Now)); }
		}

		private bool IstVolljaehrig
		{
			get { return 18 <= AktuellesAlter; }
		}
		#endregion

		#region Constructors

		public Person()
		{
			Nachname = String.Empty;
			Vorname = String.Empty;
			Geschlecht = Gender.Male;
			Geburtsdatum = new DateOnly(1900, 01, 01);
			GroesseCm = null;
			GewichtKg = null;
		}
		public Person(string nachname, string vorname, Gender geschlecht, DateOnly geburtsdatum)
			: this()
		{
			this.Nachname = nachname;
			this.Vorname = vorname;
			this.Geschlecht = geschlecht;
			this.Geburtsdatum = geburtsdatum;
		}

		public Person(string nachname, string vorname, Gender geschlecht, DateOnly geburtsdatum, int? groessecm = null, double? gewichtkg = null)
			: this(nachname, vorname, geschlecht, geburtsdatum)
		{
			GroesseCm = groessecm;
			GewichtKg = gewichtkg;
		}

		#endregion

		public string getGender()
		{
			switch (Geschlecht)
			{
				case Gender.Male:
					return "Männlich";
				case Gender.Female:
					return "Weiblich";
				case Gender.Diverse:
					return "Divers";
				default:
					return "NoGender";
			}
		}

		public int BerechneAlter(DateOnly day)
		{

			int years = day.Year - this.Geburtsdatum.Year;
			if (day < this.Geburtsdatum)
			{
				return 0;
			}
			else
			{
				if (this.Geburtsdatum.Month <= day.Month)
				{
					if (this.Geburtsdatum.Day < day.Day)
					{
						years--;
					}
					else
					{
						if (this.Geburtsdatum.Year % 400 == 0 &&(this.Geburtsdatum.Month == 02 && this.Geburtsdatum.Day == 29 && this.Geburtsdatum.Day > day.Day))
						{
							years--;
						}
					}
				}
			}
			return years;
		}

		public override string ToString()
		{
			return String.Format("Vorname: {0} \n Nachname: {1} \n Geschlecht: {2} \n Geburtsdatum: {3} \n GroesseCm: {4} \n GewichtKg: {5}", Vorname, Nachname, getGender(), Geburtsdatum, GroesseCm, GewichtKg);

		}
	}
}
