using VerwendenVonIComparer.DataAccess;
using VerwendenVonIComparer.Model;


List<int> zahlen = new List<int>() { 42, 13, 29, 1, 46 };
zahlen.Sort();
foreach(int i in zahlen)
{
    Console.WriteLine(i);
}


FakeFilmRepository repository = new();
List<Film> filme = new(repository.GetAll());
filme.Sort();
foreach (var item in filme)
{
	Console.WriteLine(item);
}
