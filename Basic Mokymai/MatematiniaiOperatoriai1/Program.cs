
using System.Text;

Console.WriteLine("Hello, Priskyrimo operatoriai = += -= *= /=!");
int skaicius;
int kitasSkaicius = 20;
int nelyginisSkaicius = 5;
skaicius = 10;
kitasSkaicius = skaicius;
Console.WriteLine($"skaicius = {skaicius}, kitasSkaicius = {kitasSkaicius}");

kitasSkaicius += nelyginisSkaicius; //kitasSkaicius = kitasSkaiciu + nelyginisSkaicius //tai analogas
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius -= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius *= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius /= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

kitasSkaicius = 21;

kitasSkaicius /= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

double doubleSkaicius = 21;
doubleSkaicius /= nelyginisSkaicius;
Console.WriteLine($"kitasSkaicius = {doubleSkaicius}");


Console.WriteLine();
Console.WriteLine("Hello, matematiniai operatoriai + - * / % ++ --");
//sudetis
int suma = skaicius + kitasSkaicius;
Console.WriteLine("suma = skaicius + kitasSkaicius = {0}", suma);
//atimtis
int atimtis = skaicius - kitasSkaicius;
Console.WriteLine("atimtis = skaicius - kitasSkaicius = {0}", atimtis);
int daugyba = skaicius * kitasSkaicius;
Console.WriteLine("daugyba = skaicius*kitasSkaicius = {0}", daugyba);
double dalyba = (double)skaicius / kitasSkaicius;
Console.WriteLine("dalyba = skaicius/kitasSkaicius = {0}", dalyba);


int matematinisRezultatas = 1 + 2 - 3 + 4 + nelyginisSkaicius - skaicius;

int dalybaSuLiekana = nelyginisSkaicius % 2;
Console.WriteLine("dalybaSuLiekana = nelyginisSkaicius % 2 = {0}", dalybaSuLiekana);

skaicius++;
Console.WriteLine($"skaicius = {skaicius}");

skaicius--;
Console.WriteLine($"skaicius = {skaicius}");


double side1 = 5.5;
double side2 = 3.25;
double height = 4.6;
double area = (side1 + side2) / 2 * height;

double areaKazkasKito = (side1 * 2 + side2) / (2 * height); //skliaustelius galima naudoti pagal matematines taisykles

Console.OutputEncoding = Encoding.UTF8;
int nulis = 0;
int int10 = 10;
long long10 = 10;
double double10 = 10;
//Console.WriteLine($"int10/nulis = {int10/nulis}"); //luzta
//Console.WriteLine($"long10/nulis = {long10 / nulis}"); //luzta
Console.WriteLine($"double10/nulis = {double10 / nulis}"); //grazina begalybe - ty begalybes implemenacija
double a = double.PositiveInfinity;
Console.WriteLine($"a = {a}");


double a1 = double.NaN; // NaN = not a number

//Overflow and Underflow
short s1 = 30_000;
short s2 = 30_000;
short s3 = (short)(s1 + s2);
Console.WriteLine($"s3={s3}");
//checked
//{ 
//   s3 = (short)(s1 + s2);
//}

//int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());


//užduotis

//Console.WriteLine("ĮVESKITE 1 SKAICIU: ");
//int pirmasSkaicius = int.Parse(Console.ReadLine());
//Console.WriteLine("ĮVESKITE 2 SKAICIU: ");
//int antrasSkaicius = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{pirmasSkaicius} + {antrasSkaicius} = {pirmasSkaicius+antrasSkaicius}");
//Console.WriteLine($"{pirmasSkaicius} + {antrasSkaicius} = {pirmasSkaicius + antrasSkaicius}");
//Console.WriteLine($"{pirmasSkaicius} - {antrasSkaicius} = {pirmasSkaicius - antrasSkaicius}");
//Console.WriteLine($"{pirmasSkaicius} * {antrasSkaicius} = {pirmasSkaicius * antrasSkaicius}");
//Console.WriteLine($"{pirmasSkaicius} / {antrasSkaicius} = {(double)pirmasSkaicius / antrasSkaicius}");

Console.WriteLine("parašykite 1 skaičių:");
double pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("parašykite 2 skaičių:");
double antrasSkaicius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("parašykite 3 skaičių:");
double treciasSkaicius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Skaiciu vidurkis: {pirmasSkaicius} + {antrasSkaicius} + {treciasSkaicius} / 3 = {(pirmasSkaicius + antrasSkaicius + treciasSkaicius) / 3}");




