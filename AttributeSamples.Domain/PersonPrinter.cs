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
        [Obsolete(message:"PrintAge() is removed",error:true)]
        public void PrintAge()
        {
            Console.WriteLine($"Age: {person.Age}");
        }

        public void PrintFullName()
        {
            Console.WriteLine($"FullName : {person.FirstName}, {person.LastName}");

        }
    }
}