using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces;

public class Flugzeug : IFlugfaehig
{
    public int AnzahlPlaetze { get; set; }

    public Flugzeug(int anzahlPlaetze)
    {
        AnzahlPlaetze = anzahlPlaetze;
    }

    public Flugzeug() : this(0) { }

    public void Starten() { Console.WriteLine("Das Flugzeug startet"); }

    public void Landen() { Console.WriteLine("Das Flugzeug landet"); }

    public void Fliegen() { Console.WriteLine("Das Flugzeug fliegt"); }
}

