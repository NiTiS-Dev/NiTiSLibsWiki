﻿using NiTiS.Additions;
using NiTiS.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Namotion.Reflection;
using System.Xml.Linq;

namespace Generator;

public sealed class TypeBuilder
{
	private readonly DocType type;
	private static readonly File ENUM_TEMP, CLASS_TEMP, INTERFACE_TEMP, STRUCT_TEMP;
	public TypeBuilder(Type type)
	{
		this.type = new(type);
	}
	public static string GetSummaryOfType(DocType type)
	{
		return type.GetXmlDocsSummary();
	}
	public static string GetInheritanceTreeOfType(DocType type)
	{
		StringBuilder builder = new();
		List<DocType> types = new();
		Type now = type.type;
		while(true)
		{
			if (now == typeof(Object))
			{
				types.Add(new(typeof(Object)));
				break;
			}
			types.Add(new (now));
			now = now.BaseType;
		}
		builder.Append("Inheritance " + Strings.FromArray(types.Select(s => s.Link).Reverse(), "", "", " {->} "));
		return builder.ToString();
	}
	public static string GetImplementsOfType(DocType type)
	{
		DocType[] interfaces = type.GetInterfaces().Select(s => new DocType(s)).ToArray();
		return interfaces.Length == 0 ? "" : "Implements " + Strings.FromArray(interfaces.Select(s => s.Link), "", "", ", ");
	}
	public static string GetAssemblyName(DocType type) => type.Assembly.GetName().Name + ".dll";
	public void GenDocs()
	{
		if (type.IsEnum)
		{
			GenEnum();
		}
		else if (type.IsInterface)
		{
			GenInterface();
		}
		else if (type.IsValueType)
		{
			GenStruct();
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
			["SHORT_NAME"] = new(() => type.NormalizedName),
			["INCODE"] = new(() => type.GenDocINCODE()),
			["FULL_NAME"] = new(() => type.FullName),
			["NAMESPACE"] = new(() => type.Namespace),
			["SUMMARY"] = new(() => GetSummaryOfType(type)),
			["ASSEMBLY"] = new(() => GetAssemblyName(type)),
			["INHERITANCE"] = new(() => GetInheritanceTreeOfType(type)),
			["IMPLEMENTS"] = new(() => GetImplementsOfType(type)),
			["CTORS"] = new(() => type.GenDocCTORS()),
		};
		UseKeys(ref temp, keys);
		Entry.WriteDoc(temp, type);
	}
	private void GenInterface()
	{
		string temp = INTERFACE_TEMP.ReadText();
		Dictionary<string, Lazy<string>> keys = new()
		{
			["SHORT_NAME"] = new(() => type.NormalizedName),
			["INCODE"] = new(() => type.GenDocINCODE()),
			["FULL_NAME"] = new(() => type.FullName),
			["NAMESPACE"] = new(() => type.Namespace),
			["SUMMARY"] = new(() => GetSummaryOfType(type)),
			["IMPLEMENTS"] = new(() => GetImplementsOfType(type)),
			["ASSEMBLY"] = new(() => GetAssemblyName(type)),
		};
		UseKeys(ref temp, keys);
		Entry.WriteDoc(temp, type);
	}
	private void GenStruct()
	{
		string temp = STRUCT_TEMP.ReadText();
		Dictionary<string, Lazy<string>> keys = new()
		{
			["SHORT_NAME"] = new(() => type.NormalizedName),
			["INCODE"] = new(() => type.GenDocINCODE()),
			["FULL_NAME"] = new(() => type.FullName),
			["NAMESPACE"] = new(() => type.Namespace),
			["SUMMARY"] = new(() => GetSummaryOfType(type)),
			["ASSEMBLY"] = new(() => GetAssemblyName(type)),
			["INHERITANCE"] = new(() => GetInheritanceTreeOfType(type)),
			["IMPLEMENTS"] = new(() => GetImplementsOfType(type)),
			["CTORS"] = new(() => type.GenDocCTORS()),
		};
		UseKeys(ref temp, keys);
		Entry.WriteDoc(temp, type);
	}
	private void GenClass()
	{
		string temp = CLASS_TEMP.ReadText();
		Dictionary<string, Lazy<string>> keys = new()
		{
			["SHORT_NAME"] = new(() => type.NormalizedName),
			["INCODE"] = new(() => type.GenDocINCODE()),
			["FULL_NAME"] = new(() => type.FullName),
			["NAMESPACE"] = new(() => type.Namespace),
			["SUMMARY"] = new(() => GetSummaryOfType(type)),
			["ASSEMBLY"] = new(() => GetAssemblyName(type)),
			["INHERITANCE"] = new(() => GetInheritanceTreeOfType(type)),
			["IMPLEMENTS"] = new(() => GetImplementsOfType(type)),
			["CTORS"] = new(() => type.GenDocCTORS()),
		};
		UseKeys(ref temp, keys);
		Entry.WriteDoc(temp, type);
	}
	private void UseKeys(ref string content, Dictionary<string, Lazy<string>> keys)
	{
		foreach (KeyValuePair<string, Lazy<string>> pair in keys)
		{
			content = content.Replace("%" + pair.Key, pair.Value.Value);
		};
	}
	static TypeBuilder()
	{
		ENUM_TEMP = new File(Entry.TEMPLATES, "enum.md");
		STRUCT_TEMP = new File(Entry.TEMPLATES, "struct.md");
		CLASS_TEMP = new File(Entry.TEMPLATES, "class.md");
		INTERFACE_TEMP = new File(Entry.TEMPLATES, "interface.md");
	}
}
