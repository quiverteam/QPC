// ============================================//
// Name: VGC.cs
// Purpose: Handles the evaluation of VGC files
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/2/2019 0:3:8
// ============================================//
using System;
using System.Collections.Generic;
using System.IO;
using QPC.Core;

namespace QPC.Core.VPCParser
{
	internal static class VGC
	{
		//
		// Parses a VGC file and returns the groups defined in that file.
		//
		public static List<Group> Parse(string path)
		{
			// We can assume the caller has checked for this before, so no need to throw exceptions
			if (!File.Exists(path))
				return null;

			// Read into a buffer, we can then evaluate includes
			string[] lines = File.ReadAllLines(path);

			return null;
		}
	}
}
