namespace Tower_Of_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Hanoi");
            Console.WriteLine("\nUŽDUOTIS nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius");
            string eilute1Stulpelis1 = "    |    ";
            string eilute2Stulpelis1 = "   #|#   ";
            string eilute3Stulpelis1 = "  ##|##  ";
            string eilute4Stulpelis1 = " ###|### ";
            string eilute5Stulpelis1 = "####|####";



            Console.WriteLine(@"
 Eil.1 {0} {5} {9}
 Eil.2 {1} {6} {10}
 Eil.3 {2} {7} {11}  
 Eil.4 {3} {8} {12}
 Eil.5 {4}", eilute1Stulpelis1, eilute2Stulpelis1, 
             eilute3Stulpelis1, eilute4Stulpelis1, 
             eilute5Stulpelis1, eilute1Stulpelis1, 
             eilute1Stulpelis1, eilute1Stulpelis1, 
             eilute1Stulpelis1, eilute1Stulpelis1, 
             eilute1Stulpelis1, eilute1Stulpelis1, 
             eilute1Stulpelis1);
            Console.WriteLine("    ----1stulp----2stulp----3stulp----");
            
            
            Console.WriteLine("----------Tęskite Toliau----------", Console.ReadKey());


         
        }
    }
}