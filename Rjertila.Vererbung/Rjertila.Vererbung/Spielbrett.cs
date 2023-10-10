using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Vererbung;

public class Spielbrett
{

	public List<Spielfeld> Felder { get; }

	public Spielbrett()
	{
		Felder = new List<Spielfeld>();
	}

	public string AusgebenSvg()
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine("<svg xmlns=\"http://www.w3.org/2000/svg\">");
		foreach(var item in Felder)
		{
			sb.AppendLine(item.AusgebenSvg());
		}
		sb.AppendLine("</svg>");
		return sb.ToString();
	}

}
