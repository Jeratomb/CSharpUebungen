using System;


namespace Rjertila.DB_Verwaltung;

public  class Datenbank
{   
    public string name { get; set; }    
    public List<Tabelle> Tabellen { get; set; }

    public Datenbank(string name)
    {
        this.name = name;
        this.Tabellen = new List<Tabelle>();
    }
}
