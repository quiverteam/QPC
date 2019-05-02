// ============================================//
// Name: Generator.cs
// Purpose:
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/1/2019 21:52:6
// ============================================//
using System;

namespace QPC.Core.Attributes
{
	//
	// Attach this to classes you want to use as generators
	//
	[AttributeUsage(AttributeTargets.Class)]
	public class Generator : System.Attribute
	{
		//
		// The name of the current generator. This will be specified on the commandline like this:
		// --generator=name
		//
		public string GeneratorName { get; set; }

		public Generator(string name)
		{

		}
	}
}
