// ============================================//
// Name: Project.cs
// Purpose: Defines the baseclass for the project
// and all other classes needed inside the element tree
// for the project.
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/1/2019 21:58:52
// ============================================//
using System;
using System.Collections.Generic;

namespace QPC.Core
{
	public class Project
	{
		//
		// Project name
		//
		public string Name { get; set; }

		//
		// Project file
		//
		public string File { get; set; }

		//
		// List of sections this project contains
		//
		public List<Section> Sections = new List<Section>();

		//
		// Condition enabling/disabling this project
		//
		public Condition Condition { get; set; }

		//
		// List of groups this project is in
		//
		public List<string> Groups = new List<string>();

		//
		// Searches the element tree and removes disabled sections based on the specified parser context
		//
		public void RemoveDisabledSections(ParserContext context)
		{
			for (int i = 0; i < Sections.Count; i++)
			{
				if (!Sections[i].Condition.Evaluate(context))
				{
					Sections.RemoveAt(i);
					continue;
				}

				Sections[i].RemoveDisabledSections(context);
				Sections[i].RemoveDisabledProperties(context);
			}
		}
	}

	public class Section
	{
		//
		// Name of the section. This is in the format as follows:
		// $SectionName "blah" "blah"
		//
		public string Name { get; set; }

		//
		// Attributes attached to this section. This is in the format as follows:
		// $SectionName "attribute1" "attribute2"
		//
		public List<string> Attributes { get; set; }

		//
		// List of child sections
		//
		public List<Section> Sections = new List<Section>();
		//
		// List of properties
		//
		public List<Property> Properties = new List<Property>();

		//
		// Conditional that enables or disables this section
		//
		public Condition Condition { get; set; }

		//
		// Removes unused properties in this section
		//
		public void RemoveDisabledProperties(ParserContext context)
		{
			for(int i = 0; i < Properties.Count; i++)
			{
				if (!Properties[i].Condition.Evaluate(context))
					Properties.RemoveAt(i);
			}
		}

		//
		// Removes unused sections in this section
		//
		public void RemoveDisabledSections(ParserContext context)
		{
			for(int i = 0; i < Sections.Count; i++)
			{
				if(!Sections[i].Condition.Evaluate(context))
				{
					Sections.RemoveAt(i);
					continue;
				}

				// Run for the child
				Sections[i].RemoveDisabledProperties(context);
				Sections[i].RemoveDisabledSections(context);
			}
		}
	}

	public class Property
	{
		//
		// Name of the property
		//
		public string Name { get; set; }

		//
		// Value(s) of the property
		//
		public List<string> Values = new List<string>();

		//
		// Conditional enabling/disabling this project
		//
		public Condition Condition { get; set; }


	}
}
