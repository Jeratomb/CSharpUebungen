using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.DB_Verwaltung;

public class UQ : Constraint
{
    public UQ(string bezeichner, string definition) : base(bezeichner, definition){}
    
    public override string ToString()
    {
        return $"Constraint ({this.Bezeichner}) UNIQUE ({this.Definition})";
    }
}
