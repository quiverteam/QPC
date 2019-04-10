using System;
using QPC.Parser;

namespace QPC
{
    public interface IParserExtension
    {
        //
        // Called when a block is just now being tokenized.
        // For example
        // $Section <anything else before opening bracket> { <- Called here
        // }
        // Returns false if parsing failed.
        //
        bool OnBeginParse(ScriptContext contex);


        //
        // Called when a block was completely tokenized.
        // For example
        // $Section {
        // } <- Called when scope is left
        // Returns false if parsing failed.
        //
        bool OnFinishParse(ScriptContext contex);
    }
}
