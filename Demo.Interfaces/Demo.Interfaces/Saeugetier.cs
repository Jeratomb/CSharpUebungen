using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces;

    public abstract class Saeugetier
    {
        public string Name { get; set; }

        public Saeugetier(string name)
        {
            Name = name;
        }
        public Saeugetier() : this("Hansi"){}
}

public class Fledermaus : Saeugetier, IFlugfaehig, IComparable<Fledermaus>
{   
    public double FluegelSpannweite {get; set; }    
    public Fledermaus() : this("Mausi", 0.1) {}

    public Fledermaus(string name, double fluegelSpannweite) : base(name) 
    {
        FluegelSpannweite = fluegelSpannweite;
    }

    public void Fliegen()
    {
        Console.WriteLine("Fledermaus fliegt");
    }

    public void Landen()
    {
        Console.WriteLine("Fledermaus landet");
    }

    public void Starten()
    {
        Console.WriteLine("Fledermaus startet");
    }

    public int CompareTo(Fledermaus? other)
    {
        if (other == null) return 1;
        return this.FluegelSpannweite.CompareTo(other.FluegelSpannweite);
    }
}
