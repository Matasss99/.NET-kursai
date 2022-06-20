namespace IF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, if!");
            int nelyginisSkaicius = 5;
            int lyginisSkaicius = 2;
            bool tiesa = true;


            if(nelyginisSkaicius > lyginisSkaicius) 
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }
           
            if (nelyginisSkaicius < lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
            }

            Console.WriteLine("if - else");
            if (nelyginisSkaicius < lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }

            Console.WriteLine("if - else if - else");
            if (nelyginisSkaicius < lyginisSkaicius && tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra true");
            }
            else if (nelyginisSkaicius < lyginisSkaicius && !tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra false");
            }
            else if (nelyginisSkaicius > lyginisSkaicius && tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra true");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra false");
            }

            Console.WriteLine("-----------------------------");
            var score = 45;
            int pointsNeededToPass = 100;
            bool levelComplete = false;
            if (score >= pointsNeededToPass)
            {   
                Console.WriteLine("Svekiname, baigete lygi!");
            }

            Console.WriteLine(score >= pointsNeededToPass ? "valio, baigete lygi" : "nevalio, bandykite dar karta");


            Console.WriteLine("-------------------------------");
            Console.WriteLine("if kompozicija, nesting"); // ifas ife
            int shields = 1, armor = 2;
            if (shields <= 0)
            {
                if (armor <= 0) 
                {
                    Console.WriteLine("jus mires");
                }
                else
                {
                    Console.WriteLine("jus dar turite armor");
                }
            }
            else
            {
                Console.WriteLine("Jus dar turite galimybiu");
            }

            if (shields <=0 && armor <= 0)
            {
                Console.WriteLine("jus mires");
            }
            else if (shields <= 0 && armor >= 0)
            {
                Console.WriteLine("jus dar turite armor");
            }
            else
            {
                Console.WriteLine("Jus dar turite galimybiu");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("null-coalescing operator (??)");
            bool? nullableBool = true;
            bool normalBool;
            //normalBool = nullableBool; // taip negalima
            normalBool = nullableBool ?? false;
            //--------------------
            nullableBool ??= false;


            /*   // uzduotis NR1
               Console.WriteLine("Iveskite skaiciu: ");
               var skaicius = Convert.ToInt32(Console.ReadLine());
               if (skaicius % 2 == 0)
               {
                   Console.WriteLine("Skaicius yra lyginis");
               }
               if (skaicius < 0)
               {
                   Console.WriteLine("skaicius yra neigiamas");
               }
               if (skaicius % 2 != 0 && skaicius > 0)
               {
                   Console.WriteLine("Skaicius " + skaicius  );
               } 

            // uzduotis NR2
            Console.WriteLine("Iveskite grupes nariu skaiciu: ");
            var nariuSkaicius = Convert.ToInt32(Console.ReadLine());
            if (nariuSkaicius == 1)
            {
                Console.WriteLine("Tai solo atlikejas");
            }
            else if (nariuSkaicius == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if (nariuSkaicius > 2 && nariuSkaicius < 10  )
            {
                Console.WriteLine("Tai ansamblis");
                
            }
            else if (nariuSkaicius >= 10)
            {
                Console.WriteLine("tai kamerinis ansamblis");
            }
            else
            {
                Console.WriteLine("Klaida");
            } */

            // uzduotis NR3
            Console.WriteLine("Iveskite isdirbtas valandas: ");
            bool arGerasSkaicius = int.TryParse(Console.ReadLine(), out int input);
            if (input < 160 && arGerasSkaicius)
            {
                Console.WriteLine($"Dar reikia isdirbti {160 - input}");
            }
            else if (input == 160)
            {
                Console.WriteLine("Isdirbtas pilnas etatas");
            }
            else if (input > 160)
            {
                Console.WriteLine($"virsvalandziu yra : {input - 160}");
            }
            else
            {
                Console.WriteLine("Klaida");
            }



            Console.WriteLine("---Press key to continue---");


        }
    }
}