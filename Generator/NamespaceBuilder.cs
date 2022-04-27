using NiTiS.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Generator;

public sealed class NamespaceBuilder
{
	private static readonly File NAMESPACE_TEMPLATE;
	private readonly List<TypeBuilder> internalTypes = new();
	private readonly string @namespace;
	public string Namepsace => @namespace;

	public NamespaceBuilder(string @namespace)
	{
		this.@namespace = @namespace;
	}
	public string GenInternalMembers()
	{
		StringBuilder builder = new();
		foreach (TypeBuilder typeBuilder in internalTypes)
		{
			builder.Append(typeBuilder.type.Link + "  \n");
		}
		return builder.ToString();
	}
	public void ApplyType(TypeBuilder builder)
	{
		internalTypes.Add(builder);
	}
	public void ApplyTypes(IEnumerable<TypeBuilder> builders)
	{
		internalTypes.AddRange(builders);
	}
	public void GenDocs()
	{
		string temp = NAMESPACE_TEMPLATE.ReadText();
		KeyDictonary keys = new()
		{
			["FULL_NAME"] = new(@namespace),
			["SHORT_NAME"] = new(@namespace.Contains('.') ? @namespace.Split('.').Last() : @namespace),
			["INTERNAL_MEMBERS"] = new(GenInternalMembers)
		};
		UseKeys(ref temp, keys);
		Entry.WriteDoc(temp, this);
	}
	private void UseKeys(ref string content, KeyDictonary keys)
	{
		foreach (KeyValuePair<string, Lazy<string>> pair in keys)
		{
			content = content.Replace("%" + pair.Key, pair.Value.Value);
		};
	}
	static NamespaceBuilder()
	{
		NAMESPACE_TEMPLATE = new File(Entry.TEMPLATES, "namespace.md");
	}
}
