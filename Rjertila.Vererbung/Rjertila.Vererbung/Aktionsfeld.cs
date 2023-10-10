using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rjertila.Vererbung;

public class Aktionsfeld : Spielfeld
{
	public string Aktion { get; set; } = String.Empty;

	public Aktionsfeld(int nr, int posX, int posY, string aktion) : base(nr, posX, posY)
	{
		//jede Klasse ist nur für ihren eigenen Attribute zuständig 
		Aktion = aktion;
	}

	// Mit override wrd das Standardverhalten der Basisklasse
	// überschrieben 
	public override string AusgebenSvg()
	{
		StringBuilder ausgabe = new StringBuilder();
		ausgabe.AppendFormat("<g transform=\"translate({0},{1})\" >", PosX, PosY);
		ausgabe.AppendLine();
		ausgabe.Append("  <rect height=\"40\" width=\"40\" stroke=\"black\" fill=\"red\" />");
		ausgabe.AppendLine();
		ausgabe.Append("  <text dx=\"20\" dy=\"25\" font-weight=\"bold\" font-size=\"20\"");
		ausgabe.AppendFormat(" font-family=\"sans\" text-anchor=\"middle\">{0}</text>", Nr);
		ausgabe.AppendLine();
		ausgabe.Append("  <text dx=\"50\" dy=\"40\" font-size=\"16\" font-family=\"sans\" ");
		ausgabe.AppendFormat("fill=\"red\">{0}</text>", Aktion);
		ausgabe.AppendLine();
		ausgabe.AppendLine("</g>");
		return ausgabe.ToString();
	}
}
