using System;
namespace QPC.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Section : System.Attribute
    {
        //
        // Name of the section
        // For example: $Name {}
        //
        public string Name;

        public Section(string name)
        {
            this.Name = name;
        }
    }
}
