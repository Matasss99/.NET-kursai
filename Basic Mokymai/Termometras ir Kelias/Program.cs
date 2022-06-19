Console.WriteLine("Įveskite 1 skaičių - temperatūra pagal Celsijų");

var temperaturaPagalCelsiju = int.Parse(Console.ReadLine());  //ivedamas norimas laipsniu skaicius
var temeperaturaPagalFarenheita = (temperaturaPagalCelsiju - 32) / 1.800; // formule kaip apskaiciuoti farenheita
var temperaturaPagalKalvina = temperaturaPagalCelsiju + 273.16; //formule kaip apskaiciuoti celsiju
var temperaturosPerskaiciavimas = (temeperaturaPagalFarenheita - 32) / 1.800; //atbuline tvarka perskaiciuojamas celsijus is farenhaito
var temperaturosPerskaiciavimas1 = temperaturaPagalCelsiju - 273.16  ; //atbuline tvarka perskaiciuojamas celsijus is kalvino
Console.WriteLine($"Jūsų temperatūra pagal farenheita: {temperaturaPagalCelsiju * 9/5 + 32}");
Console.WriteLine($"temperatūra pagal kalviną: {temperaturaPagalCelsiju + 273.16}");

Console.WriteLine($"Perskaiciuotas farenheitas i celsiju: {temperaturosPerskaiciavimas}");
Console.WriteLine(temperaturaPagalCelsiju == temperaturosPerskaiciavimas);

Console.WriteLine($"Perskaiciuotas kalvinas i celsiju: {temperaturosPerskaiciavimas1}");
Console.WriteLine(temperaturaPagalCelsiju == temperaturosPerskaiciavimas1);
temperaturaPagalKalvina = (temeperaturaPagalFarenheita - 32) / 1.800 + 273.15;
Console.WriteLine($"farenhaitas paverciamas i kalvina: {temeperaturaPagalFarenheita == temperaturaPagalKalvina}");

//termometras pagal celsiju


