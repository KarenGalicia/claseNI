using clase.ClaseHija;
using static clase.ClaseHija.Class2;

NintendoClass ccnintendo = new NintendoClass();

ccnintendo.Esportatil = true;
ccnintendo.Marca = "Nintendo";
ccnintendo.AnioLanzamiento = 2017;

string resultado = ccnintendo.MostrarDetallesNintendo();
Console.WriteLine(resultado);

Console.WriteLine("");


PlayStation ccplay = new PlayStation();
ccplay.ModeloControlador = "Soy Batman";
ccplay.Marca = "PlayStation";
ccplay.AnioLanzamiento = 2017;

resultado = ccplay.MostrarDetallesPS();
Console.WriteLine(resultado);

Console.WriteLine("");

XboxClass ccxbox = new XboxClass();

ccxbox.Marca = "Xbox";
ccxbox.AnioLanzamiento = 2015;
ccxbox.LectorDisco = true;

resultado = ccxbox.MostrardetellesXbox();
Console.WriteLine(resultado);




