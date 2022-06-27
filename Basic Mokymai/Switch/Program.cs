namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Hello, switch!");
              Console.WriteLine("Iveskite meniu punkta");
              int menuChoice = Convert.ToInt32(Console.ReadLine());
              switch (menuChoice)
              {
                  case 1:
                      Console.WriteLine("Vartotojas pasirinko 1");
                      Console.WriteLine("dar kazkokia info");
                      break;
                  case 2:
                      Console.WriteLine("Vartotojas pasirinko 2");
                      break;
                  case 3:
                      Console.WriteLine("Vartotojas pasirinko 3");
                      break;
                  case 4:
                      Console.WriteLine("Vartotojas pasirinko 4");
                      break;
                  default: // galima aprasytu default logija, ji bus vykdoma jei ne vienas case neatitiko salygos
                      Console.WriteLine("iveskite kazka");
                      var h = Console.ReadLine();
                      Console.WriteLine($"KLAIDA {h}");
                      break;
              }
              Console.WriteLine("----------------------------");
              var isvedamasRezultatas = menuChoice switch
              {
                  1 => "vartotojas pasirinko 1",
                  2 => "vartotojas pasirinko 2",
                  _ => "vartotojas nieko nepasirinko" // _ = default
              };
              Console.WriteLine(isvedamasRezultatas);

              Console.WriteLine("----------------------------");
              switch (menuChoice)
              {
                  case 1:
                  case 2:
                      Console.WriteLine("Varototojas pasirinko 1 arba 2");
                      break;
              }

              Console.WriteLine("----------------------------");
              //uzduotis
              Console.WriteLine("Iveskite egzamino pazymi");
              var pazymys = Convert.ToInt32(Console.ReadLine());
              if (pazymys >= 0 && pazymys <= 4)
              {
                  Console.WriteLine("Nepatenkinamai");
              }
              else if (pazymys == 5)
              {
                  Console.WriteLine("Silpnai");
              }
              else if (pazymys == 6)
              {
                  Console.WriteLine("Patenkinamai");
              }
              else if (pazymys == 7)
              {
                  Console.WriteLine("Vidutiniskai");
              }
              else if (pazymys == 8)
              {
                  Console.WriteLine("Gerai");
              }
              else if (pazymys == 9)
              {
                  Console.WriteLine("Labai gerai");
              }
              else if (pazymys == 10)
              {
                  Console.WriteLine("Puikiai");
              }
              //------------------------------------------
              switch (pazymys)
              {
                  case 0:
                  case 1:
                  case 2:
                  case 3:
                  case 4:
                      Console.WriteLine("Nepatenkinamai");
                      break;
                  case 5:
                      Console.WriteLine("Silpnai");
                      break;
                  case 6:
                      Console.WriteLine("Patenkinamai");
                      break;
                  case 7:
                      Console.WriteLine("Vidutiniskai");
                      break;
                  case 8:
                      Console.WriteLine("Gerai");
                      break;
                  case 9:
                      Console.WriteLine("Labai gerai");
                      break;
                  case 10:
                      Console.WriteLine("Puikiai");
                      break;
              }
              Console.WriteLine(pazymys switch //switch expression
                      {
                          0 or 1 or 2 or 3 or 4 => "Nepatenkinamai",
                          5 => "silpnai",
                          6 => "Patenkinamai",
                          7 => "Vidutiniskai",
                          8 => "gerai",
                          9 => "labai gerai",
                          10 => "Puikiai"
                      }); 
              //uzduotis "Nemokama kava"
              Console.WriteLine("Nurodykite kiek puodeliu kavos perkama");
              int puodelis = Convert.ToInt32(Console.ReadLine());

              if (puodelis >= 3)
              {
                  Console.WriteLine($"Jums priklauso {puodelis / 3} nemokami puodeliai");
              }
              else if (puodelis / 3 == 0)
              {
                  Console.WriteLine("Pirkejui nepriklauso nemokama kava");
              } 
            
            //uzduotis "Priesingi skaiciai"
            Console.WriteLine("Iveskite bet kokius 4 skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());
            var skaicius4 = Convert.ToInt32(Console.ReadLine());
            //if (skaicius1 != 0 && skaicius2 != 0 && skaicius3 != 0 && skaicius4 != 0)
            //{
            //    Console.WriteLine($"{skaicius1} -> {-skaicius1}, {skaicius2} -> {-skaicius2}, {skaicius3} -> {-skaicius3}, {skaicius4} -> {-skaicius4}");
            //}
            //else 
            //{
            //    Console.WriteLine("N/A");
            //}

            //Console.WriteLine("Iveskite bet kokius 4 skaicius");
            //var skaicius1 = Convert.ToInt32(Console.ReadLine());
            //var skaicius2 = Convert.ToInt32(Console.ReadLine());
            //var skaicius3 = Convert.ToInt32(Console.ReadLine());
            //var skaicius4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skaicius1 != 0 ? $"{skaicius1} -> {-skaicius1}" : $"0 => N/A");
            Console.WriteLine(skaicius2 != 0 ? $"{skaicius2} -> {-skaicius2}" : $"0 => N/A");
            Console.WriteLine(skaicius3 != 0 ? $"{skaicius3} -> {-skaicius3}" : $"0 => N/A");
            Console.WriteLine(skaicius4 != 0 ? $"{skaicius4} -> {-skaicius4}" : $"0 => N/A"); 

            //uzduotis "atspek skaiciu"
            Console.WriteLine("Iveskite 6 kartus skaicius nuo 1 iki 20");
            int betkoksSkaicius = 14;
            var skaicius1 = Convert.ToInt64(Console.ReadLine());
            var skaicius2 = Convert.ToInt64(Console.ReadLine());
            var skaicius3 = Convert.ToInt64(Console.ReadLine());
            var skaicius4 = Convert.ToInt64(Console.ReadLine());
            var skaicius5 = Convert.ToInt64(Console.ReadLine());
            var skaicius6 = Convert.ToInt64(Console.ReadLine());
            var skaiciusYraMazesnis = 0; */

            // uzduotis "kaledu sausainis"
            Console.WriteLine("Iveskite 4 metus atskirdami enter (formatas yyyy-mm-dd)");
            var metai1 = DateTime.Parse(Console.ReadLine());
            var metai2 = DateTime.Parse(Console.ReadLine());
            var metai3 = DateTime.Parse(Console.ReadLine());
            var metai4 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Ivesta {metai1.ToString("yyyy-MM-dd")}, {metai2}, {metai3}, {metai4}");
            if (metai1.Month == 12 && metai1.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalediniai sausainiai");
            else if (metai2.Month == 12 && metai2.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalediniai sausainiai");
            else if (metai3.Month == 12 && metai3.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalediniai sausainiai");
            else if (metai4.Month == 12 && metai4.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalediniai sausainiai");
            else
                Console.WriteLine("Palaukite kaledu");











        }
    }
}