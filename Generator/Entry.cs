using Generator;
using NiTiS.Core;
using NiTiS.IO;
using System;
using System.Reflection;

public static class Entry
{
	public static readonly Directory GLOBAL, DOCS, TEMPLATES;
	public const string SITE_URL = @"https://nitis-dev.github.io/nitis-core-wiki/";
	public static void Main() {
		//Entry logging
		Console.WriteLine("NiTiS Core Lib V:" + NiTiSCoreLib.BasicLibs[0].GetName().Version);
		Console.WriteLine("Date Time " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		Console.WriteLine($"Global directory are: {GLOBAL}");
		
		// Each of all NiTiS.Core assemblys  
		foreach (Assembly asm in NiTiSCoreLib.BasicLibs)
		{
			AssemblyParser parser = new(asm);
			parser.GenDocs();
		}
	}
	public static void WriteDoc(string content, Type type)
	{
		File to = new(DOCS, type.FullName.Replace('.', Path.DirectorySeparator).Replace('`', '-'));
		WriteDoc(content, to);
	}
	public static void WriteDoc(string content, File to)
	{
#if RELEASE
			to.Create(true);
			to.WriteText(content);
#endif
		Console.WriteLine($"File Created: {to.Path}");
	}
	static Entry()
	{
		GLOBAL = Directory.GetCurrentDirectory();
		DOCS = new(Path.Combine(GLOBAL.Path, "docs"));
		TEMPLATES = new(GLOBAL.Path, "templates");
	}
}
