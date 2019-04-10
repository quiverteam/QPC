using System;
using System.Collections.Generic;

namespace QPC.Parser
{
    public class GeneratorContext
    {
        //
        // Returns a list of parser contexts.
        // Parser contexts are project specific
        //
        public List<IParserContext> ParserContexts { get; set; }

        //
        // Generator settings lists
        // This is just here for utility reasons
        //
        public List<GeneratorSettings> GeneratorSettings { get; set; }

        //
        // Current generator settings
        //
        public GeneratorSettings CurrentGeneratorSettings { get; set; }
    }

    public class GeneratorSettings
    {
        //
        // Name of the generator
        //
        public string Name { get; set; }

        //
        // Output file name
        //
        public string OutputFile { get; set; }
    }
}