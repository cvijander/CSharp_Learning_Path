using System;
using System.Collection.Generic;

namespace Lession_1_intro

{
    public class UIHelpers
    {

		public static void GoToNextPage()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Pritisnite ENTER za sledecu stranu...");
			Console.ResetColor();
			Console.ReadLine();
		}
	}
}

    
