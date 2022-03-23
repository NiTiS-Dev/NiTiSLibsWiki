using NiTiS.Core;
using System;
using System.Linq;
using NiTiS.Additions;
using NiTiS.IO;
using System.Collections.Generic;

public static class Entry
{
	public static void Main() {
		Console.WriteLine("NiTiS Core Lib V:" + NiTiSCoreLib.BasicLibs[0].GetName().Version);
		Console.WriteLine("Date Time " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		Directory dir = new(System.IO.Directory.GetParent(Directory.GetCurrentDirectory().Path).FullName);
		Directory docs = new(dir.Path, "docs");
		Directory templates = new(dir.Path, "templates");
		docs.ThrowIfNotExists();
		templates.ThrowIfNotExists();
		foreach(var asm in NiTiSCoreLib.BasicLibs) {
			foreach(var type in asm.GetTypes()) {
				if (type.FullName.StartsWith("System") || type.FullName.StartsWith("Microsoft")) continue; //Skip internal classes
				if (type.FullName.Contains("__") || type.FullName.Contains('+')) continue; //Skip display classes
				if (type == typeof(NiTiSCoreLib)) continue;
				DocType dtype = new(type);
				string path = dtype.Namespace.Replace('.', '/');
				File docFile = new(dir, System.IO.Path.Combine("docs", path, dtype.ClearName + ".md"));
				File template = new(templates, dtype.TemplateType.GetSpecialName());
				template.ThrowIfNotExists();
				string doc = template.ReadText();
				Dictionary<string, string> dict = new()
				{
					{ "MEMBER_NAME", dtype.ClearName },
					{ "MEMBER_NAMESPACE", dtype.Namespace },
					{ "MEMBER_ASSEMBLY", dtype.Type.Assembly.GetName().Name + " V:" + dtype.Type.Assembly.GetName().Version },
				};
                foreach (var repl in dict)
                {
					doc.Replace(repl.Key, repl.Value);
                }
				docFile.WriteText(doc);
			}
			
		}
	}
	/*public static string GetTitleText(Type type)
    {
		string text = "";
		text += type.IsNotPublic ? "private " : "";
		text += type.IsPublic ? "public " : "";
		if (type.IsInterface)
		{
			text += "interface ";
		}
        else
        {
			text += type.IsSealed ? "sealed " : "";
			text += type.IsAbstract ? "abstract " : "";
			text += type.IsValueType ? "struct " : "class ";
		}
		return text + GetNameByType(type);
    }*/
}
