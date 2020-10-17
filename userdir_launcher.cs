using System;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;

class Program
    {
    static void Main(string[] args)
    {
	    // Python Program Path
	    var pythonScriptPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(".exe", "") + ".py";
	    var basename = Path.GetFileName(pythonScriptPath);
	    var dirname = Path.GetDirectoryName(pythonScriptPath);
        
	    //// pathjoin =>
	    string[] paths = {dirname, "hoge", basename};
	    
	    pythonScriptPath = Path.Combine(paths);
	    
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
    		Console.WriteLine("python.exe‚ªŒ©‚Â‚©‚è‚Ü‚¹‚ñ‚Å‚µ‚½BŠÂ‹«•Ï”PATH‚É’Ç‰Á‚µ‚Ä‚­‚¾‚³‚¢");
    	}

    }
}

