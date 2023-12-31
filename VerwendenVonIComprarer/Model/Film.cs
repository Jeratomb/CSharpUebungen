﻿namespace VerwendenVonIComparer.Model
{

	public class Film : IComparable<Film>
	{


		public string Titel { get; set; }
		public int Erscheinungsjahr { get; set; }
		public decimal Einspielergebnis { get; set; }
		public string? Filmverleih { get; set; }
		public Film(string titel, int erscheinungsjahr, decimal einspielergebnis, string? filmverleih)
		{
			Titel = titel;
			Einspielergebnis = einspielergebnis;
			Erscheinungsjahr = erscheinungsjahr;
			Filmverleih = filmverleih;
		}
		public override string ToString()
		{
			return $"{Titel, -35}|{Erscheinungsjahr}|{Einspielergebnis,8:N2}|{Filmverleih}" ;
		}
		
		public int CompareTo(Film? other) 
		{
			if(other == null) return 1 ; // null-Werte in der Reihenfolge zuerst
			// Standardsortierung: nach dm Titel alphabetisch
			return this.Titel.CompareTo(other.Titel) ;
		}
	}
}
