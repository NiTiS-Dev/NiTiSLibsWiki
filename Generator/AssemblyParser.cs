using System;
using System.Reflection;

namespace Generator;

public sealed class AssemblyParser
{
	private readonly Assembly asm;
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
			TypeBuilder builder = new(type);
			builder.GenDocs();
		}
	}
}
