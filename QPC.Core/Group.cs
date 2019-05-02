// ============================================//
// Name: Group.cs
// Purpose:
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/1/2019 23:33:14
// ============================================//
using System;
using System.Collections.Generic;

namespace QPC.Core
{
	//
	// A group in the VGC file
	//
	public class Group
	{
		//
		// Name of the group
		//
		public string Name { get; set; }

		//
		// Groups this inherits from
		//
		public List<Group> Parents = new List<Group>();

		//
		//
		//
	}
}
