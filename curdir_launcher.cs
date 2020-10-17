using System;
using System.Diagnostics;
using System.ComponentModel;

class Program
    {
    static void Main(string[] args)
    {
	    // Python Program Path
	    var pythonScriptPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(".exe", "") + ".py";
	    
	    try
	    {
	        var startInfo = new ProcessStartInfo()
	        {
	            FileName = @"python.exe",
	            UseShellExecute = false,
	            Arguments = "\"" + pythonScriptPath + "\" \"" + string.Join("\" \"", args),
	    	};
	    	
		    using (var process = Process.Start(startInfo))
	        {
	            process.WaitForExit();
	        }

		}
    	catch (Win32Exception)
    	{
    		Console.WriteLine("python.exeÇ™å©Ç¬Ç©ÇËÇ‹ÇπÇÒÇ≈ÇµÇΩÅBä¬ã´ïœêîPATHÇ…í«â¡ÇµÇƒÇ≠ÇæÇ≥Ç¢");
    	}

    }
}