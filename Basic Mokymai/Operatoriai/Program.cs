Console.WriteLine("Hello, Operatoriai!");

//Reliaciniai operatoriai == != > < >= <=
/* var skaicius = 10;
var nelyginisSkaicius = 5;
var lyginisSkaicius = 10;

Console.WriteLine(" == patikrina ar kintamieji yra lygus");
Console.WriteLine($"{skaicius}=={lyginisSkaicius} yra {skaicius==lyginisSkaicius}");
bool ar10YraLygu5 = skaicius == nelyginisSkaicius;
Console.WriteLine($"{skaicius}=={nelyginisSkaicius} yra {ar10YraLygu5}");
Console.WriteLine("-------------------------------------");
Console.WriteLine("!= patikrina ar kintamieji yra nelygus");
Console.WriteLine($"{skaicius}!={lyginisSkaicius} yra {skaicius != lyginisSkaicius}");
Console.WriteLine($"{skaicius}!={nelyginisSkaicius} yra {skaicius != nelyginisSkaicius}");
Console.WriteLine("-------------------------------------");
Console.WriteLine("> patikrina ar kaireje esanti reiksme yra didesne uz desineje");
Console.WriteLine($"{skaicius}>{lyginisSkaicius} yra {skaicius > lyginisSkaicius}"); */

long didziausias = long.MaxValue;
short maziausias = short.MaxValue;
double Rezultatas = (double)didziausias / maziausias;
Console.WriteLine($"{(double)didziausias / maziausias}");
double rezultatas1 = (Rezultatas - long.MaxValue);
Console.WriteLine($"iš rezultato atimkite maksimalu long skaiciu {rezultatas1}");
Console.WriteLine($"ir pridekite maksimalu int skaiciu {rezultatas1 + int.MaxValue}");
