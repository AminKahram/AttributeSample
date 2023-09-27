using AttributeSamples.Domain;

Person person = new();

Type personType = person.GetType();
Console.WriteLine(personType.FullName);
Console.WriteLine(personType.AssemblyQualifiedName);
Type personType2 = typeof(Person);
Console.WriteLine(personType2.FullName);

Type personType3 = Type.GetType("AttributeSamples.ReflectionUI.Teacher",true,true);
Console.WriteLine(personType3.FullName);

Type personType4 = Type.GetType("AttributeSamples.Domain.Person, AttributeSamples.Domain", true, true);
Console.WriteLine(personType4.FullName);

Console.ReadLine();