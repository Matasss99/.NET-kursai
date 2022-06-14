namespace Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki kintamieji!");



            //skaiciu kintamieji
            //sveiku skaiciu kintamieji
            byte mazasSkaicius = 2; //MAX panaudojamas skaicius = 255
            short trumpasSkaicius = 2; // MAX panaudojamas skaiciu 32767, gali tureti minusines reiksmes
            int skaicius = 2; // MAX panaudojamas skaicius - iki 2mlrd , galima naudoti minusines reiksmes
            int maksimalusIntSkaitmuo = int.MaxValue;
            int minimalusIntSkaitmuo = int.MinValue;
            long ilgasSkaicius = 2; //ilgesnio skaicio uz long nebuna
            Console.WriteLine("maksimalusIntSkaitmuo ={0}, minimalusIntSkaitmuo = {1}", maksimalusIntSkaitmuo, minimalusIntSkaitmuo);

            
        }
    }
}