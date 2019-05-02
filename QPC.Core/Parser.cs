// ============================================//
// Name: Parser.cs
// Purpose: Defines the parser
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/1/2019 22:3:58
// ============================================//
using System;
using System.Collections.Generic;
using System.IO;

namespace QPC.Core
{
	//
	// Internal state of the parser
	//
	public class ParserContext
	{
		//
		// List of macros
		//
		public Dictionary<string, string> Macros = new Dictionary<string, string>();

		//
		// Groups that this parser was submitted
		//
		public List<Group> Groups = new List<Group>();

		//
		// Current project this parser is parsing
		//
		public Project CurrentProject { get; set; }

		//
		// Current group the parser is going over
		//
		public Group CurrentGroup { get; set; }

		//
		// Default constructor
		//
		public ParserContext(Dictionary<string, string> macros, List<Group> groups)
		{
			Macros = macros;
			Groups = groups;
			CurrentGroup = null;
		}

	}

	//
	// The actual parser class
	//
	public class Parser
	{
		public ParserContext Context { internal set; get; }

		public string GroupsFile { internal set; get; }

		public string ProjectsFile { internal set; get; }

		//
		// Allows for setting the context manually
		//
		public Parser(ParserContext context)
		{
			this.Context = context;
			GroupsFile = null;
			ProjectsFile = null;
		}

		//
		// For groups specified on the command line 
		//
		public Parser(Dictionary<string, string> macros, List<Group> groups)
		{
			Context = new ParserContext(macros, groups);
			GroupsFile = null;
			ProjectsFile = null;
		}

		public Parser(Dictionary<string, string> macros, string GroupFile, string ProjectFile)
		{
			if (!File.Exists(ProjectFile))
				throw new FileNotFoundException("The supplied project listing file was invalid!");
			if (!File.Exists(GroupFile))
				throw new FileNotFoundException("The supplied group listing file was invalid!");

			GroupsFile = GroupFile;
			ProjectsFile = ProjectFile;
		}

		//
		// Creates a new instance of the parser and stuff
		//
		public static Parser Parse(Dictionary<string, string> macros, string groupfile, string projectfile)
		{
			return new Parser(macros, groupfile, projectfile);
		}
	}
}
