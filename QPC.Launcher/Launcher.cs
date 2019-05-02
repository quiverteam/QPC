// ============================================//
// Name: Launcher.cs
// Purpose: Main entry point for QPC
// Author: Jeremy Lorelli jeremy.lorelli.1337@gmail.com
// Date Of Creation: 5/1/2019 21:40:30
// ============================================//
using System;


namespace QPC.Launcher
{
    public static class Launcher
    {
		public static void Main(string[] args)
		{
			string next = "";
			if(args.Length > 1)	
				next = args[1];
			for(int i = 0; i < args.Length; i++, next = args[i+1])
			{
				
			}
		}

		public static void DisplayHelp()
		{

		}
	}
}
