using System;

namespace QPC.Attributes
{
    //
    // Apply this to a class or function that evaluates a keyword
    //
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class Keyword : System.Attribute
    {
        //
        // Possible names of the keyword
        // Keyword names are like this: $Keyword
        //
        public string[] Names;

        public Keyword(string[] names)
        {
            this.Names = names;
        }
    }
}
