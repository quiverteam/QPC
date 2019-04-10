using System;
using System.IO;

namespace QPC.Parser
{
    public interface IParser
    {
        //
        // Parses the specified file.
        // Throws a file not found exception if file is not found
        //
        void Parse(string file);

        //
        // Parses the data from a stream
        //
        void Parse(StreamReader reader);

        //
        // Sets the standard output stream
        //
        void SetStdout(Stream stdout);

        //
        // Sets the standard error stream
        //
        void SetStderr(Stream stderr);
    }
}