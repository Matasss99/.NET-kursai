namespace tipuKonversijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, tipu konversijos!");
            // implicit castin
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintasLong1 = skaiciusInt; //tipo konversija daroma automatiskai

            var castintasLong2 = (long)skaiciusInt;

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat1 = skaiciusInt2;
            float skaiciusFloat2 = skaiciusLong2;
            double skaiciusDoable = skaiciusByte;
            double skaiciusDoable1 = skaiciusInt2;
            double skaiciusDoable2 = skaiciusLong2;
            double skaiciusDoable3 = skaiciusFloat2;
            decimal skaiciusDecimal = skaiciusByte;
            //byte>short>int>long>float>double>decimal

            //Explicit castin
            int castintasInt = (int)skaiciusLong;
            //decimal>double>float>long>int>char
            float fl = 5.6f;
            int castintasInt1 = (int)fl;
            Console.WriteLine(" i ={0}", castintasInt1);

            char skaiciusRaide = 'a';
            int castintasInt2 = skaiciusRaide;
            Console.WriteLine($"  castintasInt2={castintasInt2}");
            long castintasLong3 = skaiciusRaide;
            //char>ushort>int>long>ulong>float>double>decimal

            //string a = "a";
            //int castintasInt3 = (int)a;

            long skaiciusLongdidesnis = 3_000_000_000;
            int castintasInt4 = (int)skaiciusLongdidesnis;
            Console.WriteLine($"  castintasInt4= {castintasInt4}");


            long skaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDarDidesnis;
            Console.WriteLine($"  castintasInt5={ castintasInt5}"); //castinimas explicit is didesnio keitimas i mazesni



        }
    }
}