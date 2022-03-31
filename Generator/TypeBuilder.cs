using NiTiS.Additions;
using NiTiS.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Generator;

public sealed class TypeBuilder
{
	private readonly Assembly asm;
	private readonly Type type;
	private static readonly File ENUM_TEMP, CLASS_TEMP, INTERFACE_TEMP, STRUCT_TEMP;
	public TypeBuilder(Type type)
	{
		this.asm = type.Assembly;
		this.type = type;
	}
	public static string GetNormalizedGenericName(Type type)
	{
		StringBuilder builder = new();
		if (type.IsGenericType)
		{
			string realName = type.Name.Split('`').FirstOrDefault();
			builder.Append(realName);
			builder.Append(Strings.FromArray(
				type.GetGenericArguments()
				.Select(s => GetNormalizedGenericName(type))
				, "<", ">"));
		}
		else
		{
			builder.Append(type.Name);
		}
		return builder.ToString();
	}
	public void GenDocs()
	{
		if (type.IsEnum)
		{
			GenEnum();
		}
		else if (type.IsInterface)
		{

		}
		else if (type.IsValueType)
		{

		}
		else if (type.IsClass)
		{
			GenClass();
		}
		else
		{
			Console.WriteLine("Unknown type");
		}
	}
	private void GenEnum()
	{
		string temp = ENUM_TEMP.ReadText();
		Dictionary<string, Lazy<string>> keys = new()
		{
			["SHORT_NAME"] = new(() => type.Name),
			["FULL_NAME"] = new(() => type.FullName),
			["NAMESPACE"] = new(() => type.Namespace),
			["ASSEMBLY"] = new(() => type.Assembly.GetName().Name),
		};
		foreach(KeyValuePair<string, Lazy<string>> pair in keys)
		{
			temp = temp.Replace("%" + pair.Key, pair.Value.Value);
		};
		Entry.WriteDoc(temp, type);
	}
	private void GenClass()
	{
		string temp = CLASS_TEMP.ReadText();
		Dictionary<string, Lazy<string>> keys = new()
		{
			["SHORT_NAME"] = new(() => type.Name),
			["FULL_NAME"] = new(() => type.FullName),
			["NAMESPACE"] = new(() => type.Namespace),
			["ASSEMBLY"] = new(() => type.Assembly.GetName().Name),
		};
		foreach (KeyValuePair<string, Lazy<string>> pair in keys)
		{
			temp = temp.Replace(pair.Key, pair.Value.Value);
		};
		Entry.WriteDoc(temp, type);
	}
	static TypeBuilder()
	{
		ENUM_TEMP = new File(Entry.TEMPLATES, "enum.md");
		STRUCT_TEMP = new File(Entry.TEMPLATES, "struct.md");
		CLASS_TEMP = new File(Entry.TEMPLATES, "class.md");
		INTERFACE_TEMP = new File(Entry.TEMPLATES, "interface.md");
	}
}
