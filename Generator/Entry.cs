using Generator;
using NiTiS.Core;
using NiTiS.IO;
using System;
using System.Linq;
using System.Reflection;

public static class Entry
{
	public static readonly Directory GLOBAL, DOCS, TEMPLATES, EXAMPLES;
	public const string SITE_URL = @"https://nitis-dev.github.io/NiTiSLibsWiki/";
	public static void Main() {
		//Entry logging
		Console.WriteLine("NiTiS Core Lib V:" + NiTiSCoreLib.BasicLibs[0].GetName().Version);
		Console.WriteLine("Date Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		Console.WriteLine($"Global directory are: {GLOBAL}");
		
		foreach (File exmpl in EXAMPLES.GetFiles().Where(f => f.Extension.EndsWith("json")))
		{
			File? code = EXAMPLES.GetFiles().Where(f => f.NameWithoutExtension == exmpl.NameWithoutExtension && !f.Extension.EndsWith("json")).FirstOrDefault();
			if ((code?.Exists ?? false) && exmpl.Exists)
			{
				Examples.AddExample(exmpl, code);
			}
		}
		// Each of all NiTiS.Core assemblys  
		foreach (Assembly asm in NiTiSCoreLib.BasicLibs)
		{
			AssemblyParser parser = new(asm);
			parser.GenDocs();
		}
		NamespaceBuilder.AutoGenDocs();
	}
	public static void WriteDoc(string content, NamespaceBuilder builder)
	{
		File to = new(DOCS, "Namespaces/" + builder.Namepsace + ".md");
		WriteDoc(content, to);
	}
	public static void WriteDoc(string content, Type type)
	{
		File to = new(DOCS, type.FullName?.Replace('.', Path.DirectorySeparator).Replace('`', '-') + ".md");
		WriteDoc(content, to);
	}
	public static void WriteDoc(string content, File to)
	{
		to.Create(true);
		to.WriteText(AdoptForHTML(content));
		Console.WriteLine($"File Created: {to.Path}");
	}
	public static string AdoptForHTML(string content) => content
		.Replace("{<}", "&#60;")
		.Replace("{<-}", "&#8592;")
		.Replace("{->}", "&#8594;")
		.Replace("{>}", "&#62;");
	static Entry()
	{
		GLOBAL = Directory.GetCurrentDirectory();
		DOCS = new(GLOBAL.Path, "docs");
		TEMPLATES = new(GLOBAL.Path, "templates");
		EXAMPLES = new(GLOBAL.Path, "examples");
	}
}
