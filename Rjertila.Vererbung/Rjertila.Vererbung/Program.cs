using Rjertila.Vererbung;

Spielbrett spielbrett = new();
Spielfeld feld1 = new Spielfeld(1, 40, 40);
spielbrett.Felder.Add(feld1);

Spielfeld feld2 = new Spielfeld(2, 90, 40);
spielbrett.Felder.Add(feld2);

Aktionsfeld feld3 = new(3, 90, 90, "Aussetzen");
// statt einer Spielfeld-Instanz kann auch eine Instanz 
// einer von Spielfeld abeleiteten Klasse(Objekt)
// eingesetzt werden
spielbrett.Felder.Add(feld3);


Console.WriteLine(spielbrett.AusgebenSvg());
File.WriteAllText(@"D:\Daten\rjertila\csharp\Spielbrett.svg", spielbrett.AusgebenSvg());
