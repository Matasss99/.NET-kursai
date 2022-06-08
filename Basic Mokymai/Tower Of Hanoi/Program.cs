namespace Tower_Of_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Hanoi");
            Console.WriteLine("\nUŽDUOTIS nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius");
            string eilute1Stulpelis1 = "|";
            string eilute2Stulpelis1 = "|";
            string eilute3Stulpelis1 = "|";
            string eilute4Stulpelis1 = "|";
            string eilute5Stulpelis1 = "|";
            string eilute1Stulpelis2 = "|";
            string eilute2Stulpelis2 = "|";
            string eilute3Stulpelis2 = "|";
            string eilute4Stulpelis2 = "|";
            string eilute5Stulpelis2 = "|";
            string eilute1Stulpelis3 = "|";
            string eilute2Stulpelis3 = "|";
            string eilute3Stulpelis3 = "|";
            string eilute4Stulpelis3 = "|";

  
            string pirmaEgle = "#";
            string antraEgle = "##";
            string treciaEgle = "###";
            string ketvirtaEgle = "####";
            string penktaEgle = "#####";


            Console.WriteLine($"1eil.\t {pirmaEgle}{eilute1Stulpelis1}{pirmaEgle}\t      {eilute1Stulpelis2}\t           {eilute1Stulpelis3}");
            Console.WriteLine($"2eil.   {antraEgle}{eilute2Stulpelis1}{antraEgle}\t      {eilute2Stulpelis2}\t           {eilute2Stulpelis3}");
            Console.WriteLine($"3eil.  {treciaEgle}{eilute3Stulpelis1}{treciaEgle}\t      {eilute3Stulpelis2}\t           {eilute3Stulpelis3}");
            Console.WriteLine($"4eil. {ketvirtaEgle}{eilute4Stulpelis1}{ketvirtaEgle}\t      {eilute4Stulpelis2}\t           {eilute4Stulpelis3}");
            Console.WriteLine($"5eil.{penktaEgle}{eilute5Stulpelis1}{penktaEgle}      {eilute5Stulpelis2}\t           {eilute3Stulpelis3}");
            Console.WriteLine("   ----1stulp-------2stulp-------3stulp----");


            Console.WriteLine("----------Tęskite Toliau----------", Console.ReadKey());


            Console.WriteLine($"1eil.{penktaEgle}{eilute1Stulpelis1}{penktaEgle}      {eilute1Stulpelis2}\t           {eilute1Stulpelis3}");
            Console.WriteLine($"2eil. {ketvirtaEgle}{eilute2Stulpelis1}{ketvirtaEgle}\t      {eilute2Stulpelis2}\t           {eilute2Stulpelis3}");
            Console.WriteLine($"3eil.  {treciaEgle}{eilute3Stulpelis1}{treciaEgle}\t      {eilute3Stulpelis2}\t           {eilute3Stulpelis3}");
            Console.WriteLine($"4eil.   {antraEgle}{eilute4Stulpelis1}{antraEgle}\t      {eilute4Stulpelis2}\t           {eilute4Stulpelis3}");
            Console.WriteLine($"5eil.    {pirmaEgle}{eilute5Stulpelis1}{pirmaEgle}          {eilute5Stulpelis2}\t           {eilute3Stulpelis3}");
            Console.WriteLine("   ----1stulp-------2stulp-------3stulp----");

        }
    }
}