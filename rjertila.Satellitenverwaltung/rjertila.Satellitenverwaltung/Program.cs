using rjertila.Satellitenverwaltung;

Sender DasErste = new Sender("Das Erste HD", "deutsch", Qualiteaten.HD);
Verschluesselt Rtl = new Verschluesselt("RTL UHD", "deutsch", Qualiteaten.UHD, "nagravision", "HD+");
Sender BR = new Sender("Bayerisches Fernsehen", "deutsch", Qualiteaten.SD);

List<Sender> sender = new List<Sender>();
sender.Add(DasErste);
sender.Add(Rtl);
sender.Add(BR);

Transponder t1 = new Transponder(1, Polarisationen.Horizontal, 11750, sender);

foreach(var item in sender)
{
    Console.WriteLine(item);
}