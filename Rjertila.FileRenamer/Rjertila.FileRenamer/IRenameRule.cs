using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer.Rules;

public interface IRenameRule
{
    string Type { get; set; }
    string Description { get; set; }
    string ExecuteRule();
}
