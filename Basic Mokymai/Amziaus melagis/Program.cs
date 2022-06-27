Console.WriteLine("Hello, World!");

Console.WriteLine("Įveskite savo vardą ir pavardę");
var vardasIrPavarde = Convert.ToString(Console.ReadLine());
Console.WriteLine("Įvesktie savo asmens kodą (11simb.)");
var asmensKodas = Int64.Parse(Console.ReadLine());


Console.WriteLine("Įveskite savo amžių");
var amzius = Convert.ToInt32(Console.ReadLine());
string data = DateTime.UtcNow.ToString("MM-dd-yyyy"); // sukuriamas datos formatas

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("-----------------ATASKAITA APIE ASMENĮ--------------------");
Console.WriteLine($"------------------------{data}---------------------------");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine($"Vardas, Pavardė--{vardasIrPavarde}-----------------------");
Console.WriteLine($"Lytis------------{asmensKodas}---------------------------");