using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace AttributeSamples.Domain
{
    [DebuggerDisplay("Person Name is {FirstName} and Age is {Age}")]
    [DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy ))]
    [Serializable]
    public class Person
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        [NonSerialized]
        private int Count { get; set; }
    }
}