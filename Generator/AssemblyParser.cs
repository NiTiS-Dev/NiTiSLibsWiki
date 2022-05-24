using System;
using System.Collections.Generic;
using System.Reflection;

namespace Generator;

public sealed class AssemblyParser
{
	private readonly Assembly asm;
	private readonly Dictionary<string, List<TypeBuilder>> namespaces = new();
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
			if (!String.IsNullOrWhiteSpace(space))
			{
				if (namespaces.TryGetValue(space, out List<TypeBuilder> build))
				{
					build.Add(builder);
				} else
				{
					namespaces[space] = new()
					{
						builder
					};
				}
			}
		}
		foreach (KeyValuePair<string, List<TypeBuilder>> namespaceAndBuilders in namespaces)
		{
			NamespaceBuilder namespaceBuilder = new(namespaceAndBuilders.Key);
			namespaceBuilder.ApplyTypes(namespaceAndBuilders.Value);
		}
	}
}
