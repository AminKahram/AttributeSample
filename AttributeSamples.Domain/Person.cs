using System.Diagnostics;

namespace AttributeSamples.Domain
{
    [DebuggerDisplay("Person Name is {FirstName} and Age is {Age}")]
    [DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy))]
    public class Person
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}