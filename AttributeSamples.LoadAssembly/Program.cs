using System.Reflection;

var assembly = Assembly.LoadFrom(@"D:\OromandT\2.1\AttributeSamples\AttributeSamples.Domain\bin\Debug\net6.0\AttributeSamples.Domain.dll");

var type = assembly.GetTypes();

Console.WriteLine($"***************************** {assembly.FullName} *****************************");
foreach (var t in type)
{
    Console.WriteLine(t.Name);
}

Console.ReadLine();