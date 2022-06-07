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
            var key = Console.ReadKey();
            Console.WriteLine("Įvestas simbolis {0}", key.KeyChar);

            Console.WriteLine("Įveskite savo vardą, o aš atspėsiu pirmą raidę:");
            Console.WriteLine("o štai mano spėjimas \"" + Console.ReadLine()[0] + "\"");

            Console.ReadKey();

            Console.WriteLine("eilutė 1" +
             Environment.NewLine + "eilutė 2" +
             Environment.NewLine + "eilutė 3");

            Console.WriteLine(@" "" tekstas kabutėse ""
            eilutė 1
            eilutė 2
            eilutė 3"); */

            Console.WriteLine("Mano vardas Matas");
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("įrašykite savo pirma vardo raidę");
            //Console.ReadKey();
            var vardas = Console.ReadLine();
            Console.WriteLine("įvesta raidė: {0}", vardas);
                





        }
    }
}