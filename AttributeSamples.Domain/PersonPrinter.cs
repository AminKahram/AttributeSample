using System.Diagnostics;

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
            ShowDebugData();
            ShowDeveloperName();
            PrintFullName();
            PrintAge();
        }
        [Conditional("Abbas")]
        private void ShowDeveloperName()
        {
            Console.WriteLine("Developer is Abbas");
        }

        [Conditional("DEBUG")]
        private void ShowDebugData()
        {
            Console.WriteLine($"This application is compiled in debug mode."); 
        }

        //[Obsolete(message:"PrintAge() is removed",error:true)]
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