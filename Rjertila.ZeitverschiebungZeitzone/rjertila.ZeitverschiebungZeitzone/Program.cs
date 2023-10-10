using System.Threading.Channels;

#region A1
DateTimeOffset genauesJetzt;
DateTimeOffset jetztUTC;
genauesJetzt = DateTimeOffset.Now;
	jetztUTC = DateTimeOffset.Now;
Console.WriteLine($"Der genaue Zeitpunkt ist {genauesJetzt}");
Console.WriteLine($"in UTC ist das {jetztUTC}");
#endregion

#region A2
Console.WriteLine($"{genauesJetzt} hat eine Zeitverschiebung von {genauesJetzt.Offset}");
#endregion

#region A3
DateTimeOffset termin;
termin = new DateTimeOffset(new DateTime(2012, 09, 13, 08, 0, 0));
Console.WriteLine($"Der genaue Zeitpunkt des Termins ist {termin}");
#endregion

#region A4
TimeZoneInfo lokaleZeitzone;
lokaleZeitzone = TimeZoneInfo.Local;
Console.WriteLine("Die lokale Zeitzone ist:");
Console.WriteLine($"ID: {lokaleZeitzone.Id }");
Console.WriteLine($"DisplayName: { lokaleZeitzone.DisplayName}");
#endregion

#region A5

if (lokaleZeitzone.SupportsDaylightSavingTime)
{
	if (lokaleZeitzone.IsDaylightSavingTime(DateTime.Now))
	{
		Console.WriteLine("Zur Zeit haben wir Sommerzeit");
	}
	else
	{
		Console.WriteLine("Zur Zeit haben wir Winterzeit");
	}
}
else
{
	Console.WriteLine("Die lokale Zeitzone kennt keine Sommerzeitregelung");
}

#endregion

#region A6
foreach (var item in TimeZoneInfo.GetSystemTimeZones())
{
	Console.WriteLine($"ID: {item.Id} ({item.DisplayName})");
}
#endregion

#region A7
DateTimeOffset telefonkonferenz;
telefonkonferenz = new DateTimeOffset(new DateTime(2017, 11, 25, 08, 30, 00), new TimeSpan(-3,0,0));
Console.WriteLine($"Die Telefonkonferenz findet am {telefonkonferenz.ToLocalTime()} statt");
#endregion

#region A8
DateTimeOffset pekingZeit, newYorkZeit;
pekingZeit = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTimeOffset.UtcNow, "China Standard Time");
newYorkZeit = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTimeOffset.UtcNow, "Eastern Standard Time");
Console.WriteLine($"In Peking ist es jetzt: {pekingZeit}");
Console.WriteLine($"In New York ist es jetzt: {newYorkZeit}");
#endregion

#region A9
TimeZoneInfo brasilienZeitzone = TimeZoneInfo.FindSystemTimeZoneById("Central Brazilian Standard Time");
DateTime endspielZeit = TimeZoneInfo.ConvertTime(new DateTime(2014, 7, 13, 16, 0, 0), brasilienZeitzone, TimeZoneInfo.Local);

Console.WriteLine($"Anpfiff des Fußball-WM-Endspiels 2014 war bei uns: {endspielZeit.ToLocalTime()}");
#endregion

#region A10
TimeSpan dauerBisNeujahr;
dauerBisNeujahr = new DateTime(2024, 01, 01) - DateTimeOffset.Now;
Console.WriteLine($"Bis zum Jahresbeginn sind es noch {dauerBisNeujahr.Days} Tage {dauerBisNeujahr.Hours} Stunden {dauerBisNeujahr.Minutes } Minuten und {dauerBisNeujahr.Seconds} Sekunden");
#endregion

#region A11
// .TotalMinutes gibt die gesamte Zeitspanne in Minuten zurück,
// einschließlich der Minuten und der umgerechneten Sekunden und Millisekunden.

//Der Wert von .Minutes liegt immer zwischen 0 und 59, da er nur
//die Minuten innerhalb des TimeSpan repräsentiert.
#endregion
