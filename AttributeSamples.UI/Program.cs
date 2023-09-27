using AttributeSamples.Domain;

Person Abbas = new()
{
    FirstName = "Abbas",
    LastName = "Gholami",
    Age = 10
};

PersonPrinter printer = new(Abbas);
printer.Print();

Console.ReadLine();