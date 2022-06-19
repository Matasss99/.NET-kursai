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

            //type Conversion Methods
            string kovertuotasString = Convert.ToString(skaiciusInt);
            string konvertuotasString1 = skaiciusInt.ToString();
            long konvertiotasLong = Convert.ToInt64(skaiciusInt);
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);

            //int konvertuotasInt = Convert.ToInt32(skaiciusLongdidesnis); //luztas, nes netelpa
            
            //darbas su nullable tipais
            int? skaiciusIntNull = null; // ? reikalingas, kad nuskaitytu, kad tai yra null
            //long castintasLong5 = (long)skaiciusIntNull; //luzta
            long konvertuotasLong1 = Convert.ToInt64(skaiciusIntNull); //programa neluzta o grazinama long tipo default reiksme ty 0
            Console.WriteLine($"KonvertuotasLong1: {konvertuotasLong1}");

            //parsinimas = tekstas keiciamas i skaiciu
            string skaiciusString = "100";
            string skaiciusDidelisString = "99999999999999999";
            string tekstas = "tekstas";
            int skaiciusIntParsintas = int.Parse(skaiciusString);
            Console.WriteLine($"skaiciusString + 1 {skaiciusString + 1}");
            Console.WriteLine($"skaiciusIntParsintas + 1 = {skaiciusIntParsintas + 1}");

            // int skaiciusIntParsintas1 = int.Parse(skaiciusDidelisString); //nuluzta
            int tekstasIntParsintas = int.Parse(tekstas);





        }
    }
}