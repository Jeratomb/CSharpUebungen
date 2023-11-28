// See https://aka.ms/new-console-template for more information
using Demo.Interfaces;

Console.WriteLine("Hello, World!");

List<IFlugfaehig> flugobjekte = new() {
    new Flugzeug(),
    new Fledermaus()
};

foreach(var item in flugobjekte)
{
    StartenUndFliegen(item);
}

void StartenUndFliegen(IFlugfaehig flugobjekt)
{
    flugobjekt.Starten();
    flugobjekt.Landen();
}
void DatenVerarbeiten(IDatenProvider provider)
{
    provider.Laden();
    // Mache etwas
    provider.Speichern();
}
