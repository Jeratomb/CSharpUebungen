using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.DB_Verwaltung;

public class Spalte : IDbElement
{
    public string Bezeichner { get; set; }
    public string Datentyp { get; set; }
    public bool Nullable { get; set; }

    public Spalte(string bezeichner, string datentyp, bool nullable)
    {
        Bezeichner = bezeichner;
        Datentyp = datentyp;
        Nullable = nullable;
    }
    public string getBezeichner()
    {
        return this.Bezeichner;
    }

    public string create()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Bezeichner).Append(" ").Append(Datentyp);
        if (!Nullable)
        {
            sb.Append(" NOT NULL");
        }
        return sb.ToString();
    }

}

