// ============================================//
// Name: IGenerator.cs
// Purpose:
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/1/2019 21:51:49
// ============================================//
using System;

namespace QPC.Core
{
	//
	// Generator types should inherit this
	//
	public interface IGenerator
	{
		//
		// Called when an individual project is generated.
		// For example when tier0.vpc is parsed
		//
		void OnProjectGenerate(ref ParserContext context);

		//
		// Called when a project group should be generated
		//
		void OnProjectGroupGenerate(ref ParserContext context);

		//
		// This is called after all projects have been generated
		//
		void OnProjectsGenerated(ref ParserContext context);
	}
}
