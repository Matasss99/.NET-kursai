namespace Basic_Mokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("išvedimas ");
            Console.Write("vienoje ");
            Console.Write("eilutėje ");
            Console.WriteLine();
            Console.WriteLine("tekstas kitoje eilutėje");
            Console.Write("tekstas");

            Console.WriteLine("---------------------------------");
            Console.WriteLine("išvedimas " + "vienoje " + "eilutėje "); //konkatinacija
            Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje", "eilutėje"); //kompozicija
            Console.WriteLine($"{"išvedimas"} {"vienoje"} {"eilutėje"}"); //interpoliacija
            Console.WriteLine("----------------------------------");

            Console.WriteLine("tekstas idedamas i \"kabutes\"");
            Console.WriteLine("tekstas \t idedamas \t i \"kabutes\"");

            Console.WriteLine("-----Press any key to continue-----");
            Console.Clear();

            /*Console.WriteLine("Įveskite savo vardą, o aš jį pakartosiu:");
            Console.WriteLine($"o štai mano pakartojimas {Console.ReadLine()}" );

            Console.WriteLine("Įveskite raidę");
            Console.WriteLine("Įvestas simbolis {0}", Console.Readkey().KeyChar);

            Console.WriteLine("Įveskite savo vardą, o aš atspėsiu pirmą raidę:");
            Console.WriteLine("o štai mano spėjimas \"" + Console.ReadLine()[0] + "\"");

            Console.ReadKey();

            Console.WriteLine("eilutė 1" +
             Environment.NewLine + "eilutė 2" +
             Environment.NewLine + "eilutė 3");

            Console.WriteLine(@" "" tekstas kabutėse ""
            eilutė 1
            eilutė 2
            eilutė 3"); 

            Console.WriteLine("Mano vardas Matas"); //isvesti savo varda
             Console.WriteLine(Console.ReadLine()); //nuskaitykite iš klaviaturos savo varda
            Console.WriteLine("įrašykite savo pirma vardo raidę "); //isvestis i ekrana
            Console.ReadKey();
            var vardas = Console.ReadLine();
            Console.WriteLine("įvestas ASCII: {0}", (int)Console.ReadKey().KeyChar); //kodel keyChar? 

             Console.WriteLine("įveskite savo vardo pirmaja raide ir betkoki skaiciu");
             Console.WriteLine("rezultatas yra: {0}", (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar); //nuskaitomos dvi raides, tuomet sudeda isveda rezultata

            Console.WriteLine("L\na\nb\na\ns");
            Console.WriteLine("L\ta\tb\ta\ts"); 

            Console.WriteLine("(1) Pirkti \n (2) Parduoti \n (3) Likučiai");
            Console.WriteLine(" \"pasirinkimas yra : {0} \"", Console.ReadKey().KeyChar); 

            Console.WriteLine("\u0022Labas\u0022"); 

            Console.WriteLine("parašykite savo vardą, o aš atspėsiu jūsų antrą raidę");
            Console.WriteLine(Console.ReadLine()[1]); 

            Console.WriteLine("parasykite savo varda, o as atspesiu skaiciu");
            Console.WriteLine(Console.ReadLine().Length); 

            Console.WriteLine("      {0}         {1}", Console.ReadLine(), Console.ReadLine()); 

            Console.WriteLine("\n\n\n{0}" , Console.ReadLine()); */

            Console.WriteLine(@"
                            *******************
                **                                     **
             **                                           **
             **         ()         ><       ()             **
            **                                             **
             **                                           **
               **           ^             ^              **
                **           ^           ^              **
                   **         ^^^^^^^^^^^            **
                      **                         **
                        *************************".Replace("*", "\""));


        }
    }
}