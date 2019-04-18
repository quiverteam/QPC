//
// Poor man's tokenizer for C#
// Uses regular expressions so its kinda slow
// This is actually super slow
//
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

namespace QPC
{
    //
    // Simple tokenizer
    //
    class Tokenizer
    {
        private class Token
        {
            public int Value { get; set; }
            public string RegexpString { get; set; }
            public Regex Regexp { get; set; }
            public bool GroupStart { get; set; }
            public bool GroupEnd { get; set; }
        }

        private List<Token> Tokens { get; set; } = new List<Token>();
        private Regex WhitespaceRegex { get; set; }
        private Regex CommentString { get; set; }

        public Tokenizer(Enum settings)
        {
            var fields = settings.GetType().GetRuntimeFields().Where(f => f.GetCustomAttribute<QPC.Token>() != null).ToArray();

            foreach(var f in fields)
            {

                if(typeof(int) == f.GetValue(f).GetType())
                {
                    QPC.Token attr = f.GetCustomAttribute<QPC.Token>();
                    Token token = new Token();
                    token.Value = (int)f.GetValue(token);
                    token.RegexpString = attr.Regexp;
                    token.Regexp = new Regex(attr.Regexp, RegexOptions.IgnoreCase);
                    token.GroupEnd = attr.GroupEnd;
                    token.GroupStart = attr.GroupStart;
                    Tokens.Add(token);
                }

            }
        }

        //
        // Tokenizes a string
        // Entries of -1 indicate a parsing failure
        //
        public List<int> TokenizeString(string str)
        {
            List<int> list = new List<int>();

            // First replace all whitespace chars with single spaces, remove comments
            str = CommentString.Replace(str, (match) =>
             {
                 return "";
             });

            // Replace whitespace with single space
            str = WhitespaceRegex.Replace(str, (match) =>
            {
                return " ";
            });

            List<string> strs = str.Split(' ').ToList();

            // Loop through it all
            foreach(string s in strs)
            {
                // used to order matches
                Dictionary<int, int> dict = new Dictionary<int, int>();
                foreach(Token token in Tokens)
                {
                    var match = token.Regexp.Matches(s);

                    for(int i = 0; i < match.Count; i++)
                    {
                        dict.Add(match[i].Index, token.Value);
                        s.Remove(match[i].Index, match[i].Length + match[i].Index);
                    }
                }

                // Order by 
                foreach( var kv in dict.OrderBy((arg) => arg.Key))
                {
                    list.Add(kv.Value);
                }
            }

            return list;


        }
    }

    //
    // Declares a token inside of an enum
    // Use like this
    // enum Tokens {
    //      [Token("[a-z]")]
    //      EnumVal = 10,
    // }
    //
    [AttributeUsage(AttributeTargets.Field)]
    class Token : System.Attribute
    {
        public string Regexp { get; set; }
        public bool GroupStart { get; set; }
        public bool GroupEnd { get; set; }

        public Token(string regexp, bool bGroupStart = false, bool bGroupEnd = false)
        {

        }
    }
}