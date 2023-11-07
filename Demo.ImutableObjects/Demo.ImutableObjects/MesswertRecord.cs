using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ImutableObjects;

//public record MesswertRecord
//{
//	public DateTimeOffset Zeitpunkt { get; init; }
//	public double Temperatur { get; init; }

//}

public record MesswertRecord(DateTimeOffset Zeitpunkt, double Temperatur);