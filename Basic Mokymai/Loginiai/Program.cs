
Console.WriteLine("Hello, Loginiai operatoriai!");
Console.WriteLine("&& (AND), || (OR), ! (NOT), ^ (XOR)");

Console.WriteLine("Neigimas !");
bool tiesa = true;
bool melas = !tiesa;
Console.WriteLine($"tiesa = {tiesa}");
Console.WriteLine($"melas = {melas}");
Console.WriteLine($"!melas = {!melas}");

Console.WriteLine("AND &&"); //abudu turi buti vienodi ir turi buti ijungti, tada grazina true
Console.WriteLine($"tiesa AND tiesa {tiesa && tiesa}");
Console.WriteLine($"tiesa AND melas {tiesa && melas}");
Console.WriteLine($"melas AND tiesa {melas && tiesa}");
Console.WriteLine($"melas AND melas {melas && melas}");

Console.WriteLine("OR ||"); // bent vienas turi buti ijungtas, kad grazintu true
Console.WriteLine($"tiesa OR tiesa   {tiesa || tiesa}");
Console.WriteLine($"tiesa OR melas   {tiesa || melas}");
Console.WriteLine($"melas OR tiesa   {melas || tiesa}");
Console.WriteLine($"melas OR melas   {melas || melas}");

Console.WriteLine("XOR ^"); // turi buti vienodi, kad grazintu true
Console.WriteLine($"tiesa XOR tiesa   {tiesa ^ tiesa}");
Console.WriteLine($"tiesa XOR melas   {tiesa ^ melas}");
Console.WriteLine($"melas XOR tiesa   {melas ^ tiesa}");
Console.WriteLine($"melas XOR melas   {melas ^ melas}");

Console.WriteLine("NAND ! &&");
Console.WriteLine($"tiesa NAND tiesa   {!(tiesa && tiesa)}");
Console.WriteLine($"tiesa NAND melas   {!(tiesa && melas)}");
Console.WriteLine($"melas NAND tiesa   {!(melas && tiesa)}");
Console.WriteLine($"melas NAND melas   {!(melas && melas)}");

Console.WriteLine("NOR ! ||");
Console.WriteLine($"tiesa NOR tiesa   {!(tiesa || tiesa)}");
Console.WriteLine($"tiesa NOR melas   {!(tiesa || melas)}");
Console.WriteLine($"melas NOR tiesa   {!(melas || tiesa)}");
Console.WriteLine($"melas NOR melas   {!(melas || melas)}");

Console.WriteLine("NXOR ! ^");
Console.WriteLine($"tiesa NXOR tiesa   {!(tiesa ^ tiesa)}");
Console.WriteLine($"tiesa NXOR melas   {!(tiesa ^ melas)}");
Console.WriteLine($"melas NXOR tiesa   {!(melas ^ tiesa)}");
Console.WriteLine($"melas NXOR melas   {!(melas ^ melas)}");


Console.WriteLine($"melas OR tiesa OR melas AND tiesa   {melas || tiesa || melas && tiesa}");

//int a = 5;
//int b = 5;
//int c = 6;
//bool s = a >= b && a > c || tiesa;
//Console.WriteLine(s);


//Console.WriteLine("iveskite 2 skaicius");
//var a = Convert.ToInt32(Console.ReadLine());
//var b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"ar lygus {a == b}");

Console.WriteLine("iveskite 2 skaicius");
bool a = Convert.ToBoolean(Console.ReadLine());
bool b = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine($"ar lyginiai {a && b}");