using System.Collections.Generic;

namespace ProjectName.Models
{
    public class ParentClass
    {
        public ParentClass()
        {
            this.ChildClasses = new HashSet<ChildClass>(); //unordered collection of unique elements, we create a HashSet in the constructior to help avoid exceptions when no records exists in the "many" side of the relationship. HashSet is more performant than a List. HashSet can't have duplicates
        }

        public int ParentClassId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ChildClass> ChildClasses { get; set; } //genris interface built into the .NET framwork. a collection of method signatures bundled together. contains a bundle of different methods ment to work on a generic collection.Entity requires it. outlines methods for querying and changing data. we are ensuring Entity will be able to use all the ICollection methods it requires on the object in order to act as our ORM
    }
}