// ============================================//
// Name: Launcher.cs
// Purpose: Main entry point for QPC
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/1/2019 21:40:30
// ============================================//
using System;
using System.Collections.Generic;

namespace QPC.Arg {
    enum Type {
        None,
        Flag,
    }

    class Parser {
        protected string[] args;
        public Parser(string[] args) {
            this.args = args;
        }

        public List<string> ParseString(string lname, char sname) {
            Type t = Type.None;
            string last = null;
            var values = new List<string>();

            foreach (string a in args) {
                switch(t) {
                    case Type.None:
                        if (a.Length > 2 && a.StartsWith("--")) {
                            last = a.Substring(2);
                            t = Type.Flag;
                        } else if (a.Length > 1 && a.StartsWith("-")) {
                            if (a.EndsWith(sname)) {
                                last = lname;
                                t = Type.Flag;
                            }
                        }
                        break;

                    case Type.Flag:
                        if (last == lname)
                            values.Add(a);
                        t = Type.None;
                        break;
                }
            }

            return values;
        }

        public bool ParseBool(string lname, char sname) {
            foreach (var a in args) {
                if (a.Length > 2 && a.StartsWith("--") && a.Substring(2) == lname)
                    return true;
                else if (a.Length > 1 && a.StartsWith("-") && a.Contains(sname))
                    return true;
            }
            return false;
        }
    }
}


namespace QPC.Launcher
{
    public static class Launcher
    {
		public static void Main(string[] args)
		{
			var p = new Arg.Parser(args);
		}

		public static void DisplayHelp()
		{

		}
	}
}
