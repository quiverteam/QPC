using System;
using System.Collections.Generic;

namespace QPC.Parser
{
    //
    // Base for all custom data types
    //
    public interface ICustomData
    {
        void SetName(string name);

        string GetName();
    }

    //
    // Interface for parser contexts
    // This is generally specific to VPC/VGC
    //
    public interface IParserContext
    {
        Dictionary<string, string> GetMacros();

        void AddMacro(string name, string value);

        string GetParserType();

        bool HasMacro(string name);

        //
        // Adds custom data to the parser and associates it with a name
        //
        void AddCustomData(ICustomData data, string Name);

        //
        // Returns custom data associated with the specified name
        // If not exist, returns null
        //
        ICustomData GetCustomData(string Name);

        //
        // Returns if the context has custom data
        //
        bool HasCustomData(string Name);
    }

    //
    // Represents a script context
    // Script contexts can be used to pass information about the parser around
    //
    public class ScriptContext
    {
        public int Line { get; set; }

        public string File { get; set; }

        public List<ScriptWarning> Warnings;

        public List<ScriptError> Errors;

        public IParserContext ParserContext;
    }

    //
    // An error in a VPC or VGC script
    //
    public class ScriptError
    {
        public int Line { get; set; }

        public string File { get; set; }

        public string Message { get; set; }

        public bool Fatal { get; set; }

        public ScriptError(int Line, string File, string Message, bool Fatal = false)
        {
            this.Line = Line;
            this.File = File;
            this.Message = Message;
            this.Fatal = Fatal;
        }
    }

    //
    // A warning in a VPC or VGC script
    //
    public class ScriptWarning
    {
        public int Line { get; set; }

        public string File { get; set; }

        public string Message { get; set; }

        public ScriptWarning(int Line, string File, string Message)
        {
            this.Line = Line;
            this.File = File;
            this.Message = Message;
        }
    }
}
