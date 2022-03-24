using NiTiS.Core;
using System;
using System.Linq;
using NiTiS.Additions;
using NiTiS.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Reflection;

public static class Entry
{
	public static void Main() {
		//Entry logging
		Console.WriteLine("NiTiS Core Lib V:" + NiTiSCoreLib.BasicLibs[0].GetName().Version);
		Console.WriteLine("Date Time " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		//Setup working directories
		Directory dir = Directory.GetCurrentDirectory();
		Directory docs = new(System.IO.Path.Combine(dir.Path, "docs"));
		Directory templates = new(dir.Path, "templates");
		Console.WriteLine($"Global directory are: {dir}");

		foreach(var asm in NiTiSCoreLib.BasicLibs) {
			foreach(var type in asm.GetTypes()) {
				//Ignore internal types
				if (type.FullName.StartsWith("System") || type.FullName.StartsWith("Microsoft")) continue;
				if (type.FullName.Contains("__") || type.FullName.Contains('+')) continue;
				if (type == typeof(NiTiSCoreLib)) continue;
				
				DocType dtype = new(type);
				string path = dtype.Namespace.Replace('.', '/');
				File docFile = new(dir, System.IO.Path.Combine(docs.Path, path, dtype.Type.Name + ".md"));
				File template = new(templates, dtype.TemplateType.GetSpecialName());
				template.ThrowIfNotExists();
				string doc = template.ReadText();
				Dictionary<string, string> dict = new()
				{
					["MEMBER_NAMESPACE"] = dtype.Namespace,
					["MEMBER_NAME"] = dtype.ClearName,
					["MEMBER_INCODE"] = dtype.GenerateIncode(),
					["MEMBER_ASSEMBLY"] = dtype.Type.Assembly.GetName().Name + " V:" + dtype.Type.Assembly.GetName().Version,
					["MEMBER_FIELDS"] = dtype.GenerateFields(),
					["MEMBER_PROP"] = dtype.GenerateProps(),
				};
                foreach (var repl in dict)
                {
					doc = doc.Replace(repl.Key, repl.Value);
                }
				docFile.Parent.Create();
				docFile.Create();
				docFile.WriteText(doc);
				Console.WriteLine($"Generated {docFile}");
			}
		}
	}
}
