namespace AttributeSamples.Domain
{
    public class  PersonPrinter
    {
        private readonly Person person;

        public PersonPrinter(Person person)
        {
            this.person = person;
        }
        public void Print()
        {
            PrintFullName();
            PrintAge();
        }

        private void PrintAge()
        {
            Console.WriteLine($"Age: {person.Age}");
        }

        private void PrintFullName()
        {
            Console.WriteLine($"FullName : {person.FirstName}, {person.LastName}");

        }
    }
}