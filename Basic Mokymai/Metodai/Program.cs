namespace Metodai
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            Console.WriteLine("Sukuriame pirma savo metoda");
            
            IsveskKazkaEkranan();//metodo kvietimas, kai metodas nieko negrazina ir nieko nepriima
            Console.WriteLine("-------------------------------------");
            float kazkoksSkaicius = GautiAtsitiktiniSkaiciu(); // metodo kvietimas ir grazinamos reiksmes priskyrimas
            Console.WriteLine($"Kazkoks skaicius = {kazkoksSkaicius}");
            
            Console.WriteLine("-------------------------------------");
            int a = 2;
            IsveskSkaiciuEkranan(a); //metodas su vienu parametru
            Console.WriteLine($"Skaicius a is Main {a}");
            Console.WriteLine("-------------------------------------");

            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiDuSkaiciai = DaugintiSkaicius(sk1, sk2);
            Console.WriteLine($"Sudauginti Du Skaiciai = {sudaugintiDuSkaiciai}"); // metodas su dviem parametrais grazinantis int
            Console.WriteLine("-------------------------------------");

            int sudaugintiTrysSKaiciai = DaugintiSkaicius(sk1, sk2, 2);
            Console.WriteLine($"Sudauginti trys skaiciai = {sudaugintiTrysSKaiciai}"); //metodo overloadinimas, metodas priima 3 argumentus ir grazina int 
            Console.WriteLine("-------------------------------------");

            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintiDuDoubleSKaiciai = DaugintiSkaicius(sk1d, sk2d);
            Console.WriteLine($"Sudauginti du double skaiciai = {sudaugintiDuDoubleSKaiciai}");

            double sudaugintiDuDoubleSKaiciai1 = DaugintiSkaicius((double)sk1, sk2d);
            Console.WriteLine($"Sudauginti du double skaiciai1 = {sudaugintiDuDoubleSKaiciai1}");
            Console.WriteLine("-------------------------------------");

            IsveskTekstaEkranan();
            IsveskTekstaEkranan("kazkoks tekstas");

            Console.WriteLine("-------------------------------------");

         
           // IsveskTekstaEkranan(1);
            //IsveskTekstaEkranan(1, "kazkoksSkaicius");

            Console.WriteLine("-------------------------------------");

            int patikrintasSkaicius = SkaiciausPatikrinimas(20, 50, 100);
            Console.WriteLine($"patikrintas skaicius = {patikrintasSkaicius}");

            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51);
            Console.WriteLine($"patikrintas skaicius1 = {patikrintasSkaicius1}");


            Console.WriteLine("-------------------------------------");

            Console.WriteLine("vidurkis " + Vidurkis(2,3));
            Console.WriteLine("vidurkis " + Vidurkis(2,3,8));
            Console.WriteLine("vidurkis " + Vidurkis(2, 3, 545, 654, 6548, 86, 75));
            Console.WriteLine("-------------------------------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautasSkaicius = {gautasSkaicius}");
            Console.WriteLine("-------------------------------------");

            int rsk = 2;
            Console.WriteLine($"rsk = {rsk}");
            ReferenceSkaicius(ref rsk); //reiksmes perdavimas per reference keicia reiksme kviecianciame metode
            Console.WriteLine($"po ReferenceSkaicius rsk = {rsk}");
            Console.WriteLine("-------------------------------------");

            //lokalios funkcijos
            int Add(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Add(2,2));


        }

        public static void ReferenceSkaicius(ref int skaicius)
        {
            skaicius = 900;
        }





        public static void GautiSkaiciu(out int skaicius)
        {
            skaicius = 2;
        }












        public static double Vidurkis(params int[] skaiciai)
        {
            double total = 0;
            foreach (var skaicius in skaiciai)
            {
                total += skaicius;
            }
            return total / skaiciai.Length;
        }










        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;
            }
            if (skaicius > max)
            {
                return max;
            }
            return skaicius;

        }






        public static void IsveskTekstaEkranan(string tekstas = "tekstas neivestas")
        {
            Console.WriteLine("tekstas " + tekstas);
        }

        public static void IsveskSkaiciuIrTekstaEkranan(int skaicius, string tekstas = "tekstas neivestas")
        {
            Console.WriteLine($"skaicius - {skaicius}, tekstas - {tekstas}" );
        }









        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
           return sk1 * sk2 * sk3;
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        public static void IsveskSkaiciuEkranan(int a)
        {
            a = a + 8;
            Console.WriteLine($"Skaicius yra {a}");
        }

        public static float GautiAtsitiktiniSkaiciu()
        {
            float a = 4;
            return a + 4.686868f;
        }

        public static void IsveskKazkaEkranan()
        {
            Console.WriteLine("Isvedu kazka");
        }

    }
}