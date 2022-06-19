Console.WriteLine("Įveskite 1 skaičių - temperatūra pagal Celsijų");

var temperaturaPagalCelsiju = int.Parse(Console.ReadLine());
var temeperaturaPagalFarenheita = temperaturaPagalCelsiju * 9 / 5 + 32;
var temperaturaPagalKalvina = temperaturaPagalCelsiju + 273.16;
var temperaturosPerskaiciavimas = (temeperaturaPagalFarenheita - 32) / 1.800;
Console.WriteLine($"Jūsų temperatūra pagal farenheita: {temperaturaPagalCelsiju * 9/5 + 32}");
Console.WriteLine($"temperatūra pagal kalviną: {temperaturaPagalCelsiju + 273.16}");
Console.WriteLine($"Perskaiciuotas farenheitas i celsiju: {(temeperaturaPagalFarenheita - 32 ) / 1.800}");
Console.WriteLine(temperaturaPagalCelsiju == temperaturosPerskaiciavimas);