//Creating simple application using Notepad.exe and csc.exe
using System;

class SimpleApp
{
	static void Main()
	{
		Console.WriteLine("It's Alive!");
		Console.ReadKey();
	}
}

//to compile SimpleApp:
/*
1) Download .Net framework SDK (https://www.microsoft.com/net/default.aspx or https://msdn.microsoft.com/aa496123 for example);
2) run csc.exe (in my case, easiest way to do that is to Win+S "Developer Command Prompt for VS2015");
3) change directory, from default to folder with SimpleApp inside, by using command 'cd' (for example 'cd D:\SimpleAppFolder');
4) compile SimpleApp by using command 'csc SimpleApp.cs'.
*/