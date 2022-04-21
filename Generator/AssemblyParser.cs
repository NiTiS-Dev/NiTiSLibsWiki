using System;
using System.Collections.Generic;
using System.Reflection;

namespace Generator;

public sealed class AssemblyParser
{
	private readonly Assembly asm;
        private readonly Dictionary<string, TypeBuilder> namespaces = new();
	public AssemblyParser(Assembly asm) => this.asm = asm;
	public void GenDocs()
	{
		foreach (Type type in asm.GetTypes())
		{
			if (type.FullName.StartsWith("System") //Delete attribute embed types
				|| type.FullName.StartsWith("Microsoft")
				|| type.FullName.Contains("__") //Delete display classes
				|| type.FullName.Contains('+')
	  			) continue;
                        string space = type.Namespace;  
			TypeBuilder builder = new(type);
			builder.GenDocs();
                        namespaces[space] = builder;
                        //TODO: Create namepsaces pages
		}
	}
}
