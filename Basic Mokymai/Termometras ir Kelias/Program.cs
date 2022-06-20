Console.WriteLine("Įveskite 1 skaičių - temperatūra pagal Celsijų");

var Celcius = int.Parse(Console.ReadLine());  //ivedamas norimas laipsniu skaicius
var Farenhait = (Celcius - 32) / 1.800; // formule kaip apskaiciuoti farenheita
var Kelvin = Celcius + 273.16; //formule kaip apskaiciuoti celsiju
var temperaturosPerskaiciavimas = (Farenhait - 32) / 1.800; //atbuline tvarka perskaiciuojamas celsijus is farenhaito
var temperaturosPerskaiciavimas1 = Celcius - 273.16  ; //atbuline tvarka perskaiciuojamas celsijus is kalvino
Console.WriteLine($"Jūsų temperatūra pagal farenheita: {Celcius * 9/5 + 32}");
Console.WriteLine($"temperatūra pagal kalviną: {Celcius + 273.16}");

Console.WriteLine($"Perskaiciuotas farenheitas i celsiju: {temperaturosPerskaiciavimas}");
Console.WriteLine($"{Celcius == temperaturosPerskaiciavimas}");

Console.WriteLine($"Perskaiciuotas kalvinas i celsiju: {temperaturosPerskaiciavimas1}");
Console.WriteLine(Celcius == temperaturosPerskaiciavimas1);
Kelvin = (Farenhait - 32) / 1.800 + 273.15;
Console.WriteLine($"farenhaitas paverciamas i kalvina: {Farenhait == Kelvin}");

//termometras pagal celsiju

// Kintamieji
double CelciusP40 = Celcius + 40;
double CelciusP35 = Celcius + 35;
double CelciusP30 = Celcius + 30;
double CelciusP25 = Celcius + 25;
double CelciusP20 = Celcius + 20;
double CelciusP15 = Celcius + 15;
double CelciusP10 = Celcius + 10;
double CelciusP05 = Celcius + 5;
double CelciusN40 = Celcius - 40;
double CelciusN35 = Celcius - 35;
double CelciusN30 = Celcius - 30;
double CelciusN25 = Celcius - 25;
double CelciusN20 = Celcius - 20;
double CelciusN15 = Celcius - 15;
double CelciusN10 = Celcius - 10;
double CelciusN05 = Celcius - 5;

// Termometras
Console.WriteLine("\nTermometras:");
Console.WriteLine("");
Console.WriteLine($"  ^F        -        ^C  ");
Console.WriteLine($" {(CelciusP40 * 9 / 5) + 32} \t - | | -    {CelciusP40}");
Console.WriteLine($" {(CelciusP35 * 9 / 5) + 32} \t - | | -    {CelciusP35}");
Console.WriteLine($" {(CelciusP30 * 9 / 5) + 32} \t - | | -    {CelciusP30}");
Console.WriteLine($" {(CelciusP25 * 9 / 5) + 32} \t - | | -    {CelciusP25}");
Console.WriteLine($" {(CelciusP20 * 9 / 5) + 32} \t - | | -    {CelciusP20}");
Console.WriteLine($" {(CelciusP15 * 9 / 5) + 32} \t - | | -    {CelciusP15}");
Console.WriteLine($" {(CelciusP10 * 9 / 5) + 32} \t - | | -    {CelciusP10}");
Console.WriteLine($" {(CelciusP05 * 9 / 5) + 32} \t - | | -    {CelciusP05}");
Console.WriteLine($" {(Celcius * 9 / 5) + 32} \t - |#| -    {Celcius}   ");
Console.WriteLine($" {(CelciusN05 * 9 / 5) + 32} \t - |#| -    {CelciusN05}");
Console.WriteLine($" {(CelciusN10 * 9 / 5) + 32} \t - |#| -    {CelciusN10}");
Console.WriteLine($" {(CelciusN15 * 9 / 5) + 32} \t - |#| -    {CelciusN15}");
Console.WriteLine($" {(CelciusN20 * 9 / 5) + 32} \t - |#| -    {CelciusN20}");
Console.WriteLine($" {(CelciusN25 * 9 / 5) + 32} \t - |#| -    {CelciusN25}");
Console.WriteLine($" {(CelciusN30 * 9 / 5) + 32} \t - |#| -    {CelciusN30}");
Console.WriteLine($" {(CelciusN35 * 9 / 5) + 32} \t - |#| -    {CelciusN35}");
Console.WriteLine($" {(CelciusN40 * 9 / 5) + 32} \t - |#| -    {CelciusN40}");
Console.WriteLine($"          (###)       ");
Console.WriteLine($"           |_|       ");
Console.WriteLine("");

