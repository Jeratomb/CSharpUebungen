using rjertila.Satellitenverwaltung;

Sender DasErste = new Sender("Das Erste HD", "deutsch", Qualiteaten.HD);
Verschluesselt Rtl = new Verschluesselt("RTL UHD", "deutsch", Qualiteaten.UHD, "nagravision", "HD+");
Sender BR = new Sender("Bayerisches Fernsehen", "deutsch", Qualiteaten.SD);
Transponder t1 = new Transponder(1, Polarisationen.Horizontal, 11750);

t1.Sender.Add(DasErste);
t1.Sender.Add(Rtl);
t1.Sender.Add(BR);


Console.WriteLine(t1);

