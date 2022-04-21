﻿using System;
using System.Collections.Generics;
using System.Reflection;

namespace Generator;

public sealed class AssemblyParser
{
	private readonly Assembly asm;
        private readonly Dictonary<string, TypeBuilder> namespaces = new();
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
                        string @namepsace = type.Namespace;  
			TypeBuilder builder = new(type);
			builder.GenDocs();
                        namespaces[@namespace] = builder; 
                        //TODO: Create namepsaces pages
		}
	}
}