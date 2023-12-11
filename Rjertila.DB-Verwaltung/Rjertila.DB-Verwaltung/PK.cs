using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.DB_Verwaltung;

public class PK : Constraint
{
    public PK(string bezeichner, string definition) : base(bezeichner, definition) {}

    public override string ToString()
    {
        return $"Constraint ({this.Bezeichner}) PRIMARY KEY ({this.Definition})";
    }
}
