using System;
using System.Collections.Generic;

namespace QPC.Parser
{
    //
    // Parser for VPC files
    //
    public class VPCParser : IParserContext, IParser
    {
        public Dictionary<string, string> Macros;



        public string GetParserType()
        {
            return "vpc";
        }

        public void AddMacro(string name, string value)
        {
            if (!Macros.ContainsKey(name))
                Macros.Add(name, value);
        }

        public bool HasMacro(string name)
        {
            return Macros.ContainsKey(name);
        }

        public Dictionary<string, string> GetMacros()
        {
            return Macros;
        }

        //
        // Parses the specified VPC script
        //
        public void Parse(string file)
        {

        }

        //
        // Resolve includes and insert into the specified buffer
        //
        private void ResolveIncludes()
        {

        }

        private void 
    }
}
