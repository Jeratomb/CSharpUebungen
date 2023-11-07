using Basics.Vererbung;

Oberklasse object1 = new Oberklasse();
object1.OberEigenschaft = "Klug";
object1.MacheEtwas();

Unterklasse object2 = new Unterklasse();
object2.OberEigenschaft = "Stark";
object2.UnterEigenschaft = "Hungrig";
object2.MacheEtwas();

Unterklasse unter1 = new Unterklasse() { OberEigenschaft = "Schnell", UnterEigenschaft = "Kreativ"};
Oberklasse object3 = unter1;
object3.MacheEtwas();
