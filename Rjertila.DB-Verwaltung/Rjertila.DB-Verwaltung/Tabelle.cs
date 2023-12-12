using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.DB_Verwaltung;

public class Tabelle : IDbElement
{
    public string Bezeichner { get; set; }
    public List<Spalte> Spalten { get; set; }
    public List<Constraint> Constraints { get; set; }
    
    public Tabelle()
    {
        Spalten = new List<Spalte>();
        Constraints = new List<Constraint>();
    }
    public Tabelle(string bezeichner, List<Spalte> spalten, List<Constraint> constraints)
    {
        Bezeichner = bezeichner;
        Spalten = spalten;
        Constraints = constraints;
    }   

     public string create()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("CREATE TABLE ");
        sb.Append(Bezeichner);
        sb.Append(" (");
        foreach (Spalte spalte in Spalten)
        {
            sb.Append(spalte.Bezeichner);
            sb.Append(" ");
            sb.Append(spalte.Datentyp);
            if (!spalte.Nullable)
            {
                sb.Append(" NOT NULL");
            }
            sb.Append(", ");
        }
        foreach (Constraint cst in Constraints)
        {
            sb.Append(cst.ToString());
        }
        sb.Remove(sb.Length - 2, 2);
        sb.Append(");");
        return sb.ToString();
    }   

    public void addSpalte(Spalte spalte)
    {
        foreach(Spalte s in Spalten)
        {
            if (s.Bezeichner.Equals(spalte.Bezeichner))
                throw new Exception("Spalte mit diesem Bezeichner existiert bereits");
        }
        Spalten.Add(spalte);
    }   

    public void removeSpalte(Spalte spalte){Spalten.Remove(spalte); }   

    public void addConstraint(Constraint constraint) { Constraints.Add(constraint); }
    public void removeConstraint(Constraint constraint) { Constraints.Remove(constraint); }

    public string getBezeichner(){ return this.Bezeichner; }

    public override string ToString(){ return $"Tabelle ({this.Bezeichner})"; }
}
