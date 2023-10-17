using Rjertila.Getraenkeverwaltung;

Getraenk Wasser = new Getraenk("Wasser", 500);
	Heissgetraenk Espresso = new Heissgetraenk("Espresso", 30, 93);
		Tee Schwarztee = new Tee("Schwarztee", 125, 80, 3);
		Punsch Beerenpunsch = new Punsch("Beerenpunsch", 200, 75, 4.5);
	Kaltgetraenk Orangenlimonade = new Kaltgetraenk("Orangenlimonade", 330, 1);
		Schorle Apfelschorle = new Schorle("Apfelschorle", 250, 2, 70);

List<Getraenk> getraenke = new();
getraenke.Add(Wasser);
getraenke.Add(Espresso);
getraenke.Add(Schwarztee);
getraenke.Add(Beerenpunsch);
getraenke.Add(Orangenlimonade);
getraenke.Add(Apfelschorle);

foreach (var item in getraenke)
{
    Console.WriteLine(item);
}