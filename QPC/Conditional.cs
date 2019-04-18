using System;
namespace QPC.VPC
{
    //
    // Conditionals are expressions that come at the end of the line
    // These can be evaluated by setting inputs 
    //
    public class Conditional
    {
        //
        // Internal constructor
        //
        internal Conditional()
        {

        }

        public Conditional(string str)
        {
            // Parse conditional

            // Clean up the brackets, we can assume that the string is formatted properly
            str.Remove(0, 1);
            str.Remove(str.Length - 1, 1);

            // Replace whitespace
            str.Replace(" ", "");
            str.Replace("\t", "");
            str.Replace("\n", "");
        }

        //
        // Parses an expression in the format
        // [true||false&&(false||true)] or true||false&&(false||true)
        //
        public static Conditional Parse(string condition)
        {
            Conditional ret = new Conditional(condition);

            return ret;
        }
    }
}
