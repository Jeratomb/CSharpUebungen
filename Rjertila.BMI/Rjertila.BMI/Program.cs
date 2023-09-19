// See https://aka.ms/new-console-template for more information

using Rjertila.BMI;
using System.ComponentModel.DataAnnotations;

Person[] array = new Person[4];
array[0] = new Person("Kugelblitz", "Klaus", rjertila.bmi.Gender.Male, new DateOnly(1981, 02, 19));
array[1] = new Person("Müsli", "Martina", rjertila.bmi.Gender.Female, new DateOnly(1984,07,25));
array[2] = new Person("Groß", "Günther", rjertila.bmi.Gender.Male, new DateOnly(1996,02,29));

foreach(Person p in array)
{
    Console.WriteLine(p);
    Console.WriteLine("--------------------------");
}
		





