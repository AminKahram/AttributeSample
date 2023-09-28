using AttributeSamples.DiscoveringMetadata;
using AttributeSamples.Domain;

var intPrinter = new MetaDataPrinter(typeof(int));
var personPrinter = new MetaDataPrinter(typeof(Person));

//intPrinter.Print();
//Console.WriteLine("Press a key to continue");
//Console.ReadLine();
//Console.Clear();

personPrinter.Print();
Console.WriteLine("Press a key to exit");
Console.ReadKey();
