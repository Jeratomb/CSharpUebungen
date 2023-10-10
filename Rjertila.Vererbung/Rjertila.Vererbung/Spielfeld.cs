using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Vererbung;

public class Spielfeld
{
	public int Nr { get; set; }
	public int PosX { get; set; }
	public int PosY { get; set; }


	public Spielfeld(int nr, int posX, int posY)
	{
		Nr = nr;
		PosX = posX;
		PosY = posY;
	}

	// virtual: von Spielfeld abeleitete Klassen dürfen das
	// Verhalten durch Überschreiben ändern
	public virtual string AusgebenSvg()
	{
		StringBuilder ausgabe = new StringBuilder();
		ausgabe.AppendFormat("<g transform=\"translate({0},{1})\" >", PosX, PosY);
		ausgabe.AppendLine();
		ausgabe.Append("  <circle r=\"20\" stroke=\"black\" fill=\"white\" />");
		ausgabe.AppendLine();
		ausgabe.Append("  <text dy=\"5\" font-weight=\"bold\" font-size=\"20\"");
		ausgabe.AppendFormat(" nt-family=\"sans\" text-anchor=\"middle\">{0}</text>", Nr);
		ausgabe.AppendLine();
		ausgabe.AppendLine("</g>");
		return ausgabe.ToString();
	}

}
