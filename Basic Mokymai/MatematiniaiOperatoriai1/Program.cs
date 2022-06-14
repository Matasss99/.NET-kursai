
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

