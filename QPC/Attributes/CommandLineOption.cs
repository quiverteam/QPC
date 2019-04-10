using System;

namespace QPC.Attributes
{
    //
    // Defines a new command line option
    // The option can have nay number of parameters
    //
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class CommandLineOption : System.Attribute
    {
        //
        // Number of parameters
        //
        public int[] ParamCount { get; set; }

        //
        // Name of the option
        //
        public string Name { get; set; }

        public CommandLineOption(string name, params int[] paramcnt)
        {
            ParamCount = paramcnt;
            Name = name;
        }
    }
}