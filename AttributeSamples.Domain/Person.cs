using AttributeSamples.CustomAttributes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace AttributeSamples.Domain
{
    [DebuggerDisplay("Person Name is {FirstName} and Age is {Age}")]
    [DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy ))]
    [Serializable]
    [CodeChangeHistory("Abbas Abbassi",Description = "Add new Property with name ")]
    [CodeChangeHistory("Gholam Abbassi", IsBug:true, Description = "fix this bug")]
    public class Person
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [CodeChangeHistory("Abbas Abbassi", IsBug:true, Description = "This property makes bugs in code")]

        public string LastName { get; set; }
        public int Age { get; set; }
        [NonSerialized]
        private int Count;
    }
}