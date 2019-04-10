using System;

namespace QPC.Attributes
{
    //
    // A step in the generation phase of things
    // Called once a VPC project is being generated
    //
    public class GenerationStep
    {
        public GenerationStep()
        {

        }
    }

    //
    // A special generator for projects or other things
    // Passed on the command line as: --generator=name
    //
    public class Generator
    {
        public string Name { get; set; }

        public Generator(string name)
        {
            Name = name;
        }
    }
}
