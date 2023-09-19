// See https://aka.ms/new-console-template for more information

using Rjertila.BMI;

Person[] array = new Person[3];
array[0] = new Person("Kugelblitz", "Klaus", rjertila.bmi.Gender.Male, new DateOnly(1981, 02, 19), 157, 96.3);
array[1] = new Person("Müsli", "Martina", rjertila.bmi.Gender.Female, new DateOnly(1984,07,25), 175);
array[2] = new Person("Groß", "Günther", rjertila.bmi.Gender.Male, new DateOnly(1996,02,29),203, 74.6);
DateOnly now = new DateOnly(2023, 09, 19);
Person test = new Person("s", "asds", rjertila.bmi.Gender.Male, new DateOnly(2000, 02, 29));

foreach(Person p in array)
{
    Console.WriteLine(p.BerechneAlter(now));
    Console.WriteLine(p);
    Console.WriteLine("--------------------------");
}
Console.WriteLine(test.BerechneAlter(new DateOnly(2003,03,1)));
