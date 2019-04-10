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
    }
}
