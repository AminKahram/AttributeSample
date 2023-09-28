using System.Reflection;

var assembly = Assembly.LoadFrom(@"D:\OromandT\2.1\AttributeSamples\AttributeSamples.Domain\bin\Debug\net6.0\AttributeSamples.Domain.dll");
var personType = assembly.GetType("AttributeSamples.Domain.Person");

var person = Activator.CreateInstance(personType);

Console.WriteLine($"My object type is {person}");
//var personMethods = personType.GetMethods();
//foreach (var item in personMethods)
//{
//    Console.WriteLine(item.Name );   
//}
var printMethod = personType.GetMethod("Print");
printMethod.Invoke(person, null);
//printMethod.Invoke(person, new object[] {"Testing method overload and input parameter in late binding" });

var inputPrinter = personType.GetMethod("InputPrinter");
inputPrinter.Invoke(person, new object[] {"Testing input printer" });


Console.ReadKey();