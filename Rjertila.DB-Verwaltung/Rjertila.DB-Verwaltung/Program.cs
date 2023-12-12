using Rjertila.DB_Verwaltung;

Datenbank db = new Datenbank("TestDB");
Tabelle t1 = new Tabelle();
Tabelle t2 = new Tabelle();
t1.Bezeichner = "TestTabelle1";
t2.Bezeichner = "TestTabelle2";
db.Tabellen.Add(t1);
db.Tabellen.Add(t2);
t1.Spalten.Add(new Spalte("TestSpalte1", "int", true));
t1.Spalten.Add(new Spalte("TestSpalte2", "varchar(255)", false));
t1.Spalten.Add(new Spalte("TestSpalte3", "varchar(255)", true));
t1.Spalten.Add(new Spalte("TestSpalte4", "varchar(255)", false));
Constraint constraint1 = new PK("PK", "Primary Key");
Constraint constraint2 = new UQ("UQ", "Unique");
t1.Constraints.Add(constraint1);
t1.Constraints.Add(constraint2);

Console.WriteLine(db.Bezeichner);