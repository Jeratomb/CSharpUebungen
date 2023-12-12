using System;
using System.Xml.Linq;


namespace Rjertila.DB_Verwaltung;

public  class Datenbank : IDbElement
{   
    public string Bezeichner { get; set; }    
    public List<Tabelle> Tabellen { get; set; }

    public Datenbank(string name)
    {
        this.Bezeichner = name;
        this.Tabellen = new List<Tabelle>();
    }

    public override string ToString()
    {
        return $"Datenbank ({this.Bezeichner})";
    }

    public string getBezeichner()
    {
        return this.Bezeichner;
    }

    public string create()
    {
        return $"CREATE DATABASE {name};";
    }

}
