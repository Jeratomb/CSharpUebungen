using System;
using System.Security.Cryptography;

namespace Notenverwaltung.Model
{
	public class Zensur
	{
		#region Properties
		public string Fach { get; set; }
		public DateTime Datum { get; set; }
		public int Note { get; set; }

		public Leistungsart Art { get; set; }

		#endregion

		#region Constructors
		public Zensur(string fach, DateTime datum, int note, Leistungsart leistungsart)
		{
			Fach = fach;
			Datum = datum;
			Note = note;
			Art = leistungsart;
		}
		public Zensur() : this(String.Empty, DateTime.Today, 1, Leistungsart.KA) { }

		#endregion

		public string FormatZensur()
		{
            string formattedDate = this.Datum.ToString("ddMMyyyy");
			if(this.Art == Leistungsart.MDL)
			{
                return $"2:{formattedDate}{this.Art}{this.Note}";
            }else
			{
                return $"2:{formattedDate}{this.Art} {this.Note}";
            }
            
		}
	}
}
