using Namotion.Reflection;
using NiTiS.Additions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Generator;

public sealed class DocType : Type
{
	internal readonly Type type;
	public DocType(Type type) => this!.type = type;
	public string NormalizedName => GetNormalizedGenericName(this.type);
	public string Link => type.IsArray ? new DocType(type.GetElementType()).Link + "[]": $"[{NormalizedName}]({GetDocAdress()})";
	public string NamespaceLink => $"[{Namespace}]({GetNamespaceDocAdress()})";
	public string Summary => type.GetXmlDocsSummary();
	public string GetDocAdress()
	{
		if (type.Namespace.StartsWith("System"))
		{
			return @$"https://docs.microsoft.com/dotnet/api/{(type.Namespace + "." + type.Name.Replace('`', '-')).ToLower()}";
		} else {
			return $"{Entry.SITE_URL}{type.Namespace.Replace('.', '/')}/{type.Name.Replace('`', '-')}";
		}
	}
	public string GetNamespaceDocAdress() => $"{Entry.SITE_URL}Namespaces/{type.Namespace}";
	public string GetDocENUMS()
	{
		StringBuilder builder = new();
		string[] names = type.GetEnumNames();
		Array enums = type.GetEnumValues();

		for (int i = 0; i < names.Length; i++)
		{
			if (i == 0) builder.Append("## Values\n");
			builder.Append($"{names[i]} = {Convert.ChangeType(enums.GetValue(i), ((Enum)enums.GetValue(i)).GetTypeCode())}  \n");
		}

		return builder.ToString();
	}
	public string GenDocEXMETHODS()
	{
		StringBuilder builder = new();
		IEnumerable<MethodInfo> exMethods = GetExtensionMethods(type);
		if (exMethods.Count() > 0)
		{
			builder.Append("## Extension Methods\n");
			foreach (MethodInfo info in exMethods)
			{
				builder.Append($"{new DocType(info.ReturnType).Link} {info.DeclaringType.Namespace}.{info.Name}{Strings.FromArray(info.GetParameters().Select(s => $"{(s.IsIn ? "in " : "")}{(s.IsOut ? "out " : "")}{new DocType(s.ParameterType).Link} {s.Name}").Skip(1), "(", ")")}  \n");
				string doc = info.GetXmlDocsSummary();
				builder.AppendLine((doc.Length > 0 ? "##### " : "") + doc);
			}
		}
		return builder.ToString();
	}
	private static readonly IEnumerable<MethodInfo> exMethods =
		AppDomain.CurrentDomain.GetAssemblies()
			.Where(s => !s.GetName().Name.StartsWith("Namotion"))
			.SelectMany(s => s.GetTypes())
			.Where(t => t.IsSealed && !t.IsGenericType && !t.IsNested)
			.SelectMany(s => s.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
			.Where(m => m.IsDefined(typeof(ExtensionAttribute), false))
			.Where(m => m.ReturnType.Name != "Byte&");
	private static IEnumerable<MethodInfo> GetExtensionMethods(Type t)
		=> exMethods.Where(m => t.IsAssignableTo(m.GetParameters()[0].ParameterType));
	public string GenDocMETHODS()
	{
		StringBuilder builder = new();
		IEnumerable<MethodInfo> methods = type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic);
		methods = methods.Where(s => !s.IsSpecialName);
		IEnumerable<MethodInfo> statMethods = methods.Where(s => s.IsStatic);
		methods = methods.Where(s => !s.IsStatic);
		if (methods.Count() > 0)
		{
			builder.Append("## Methods\n");
			foreach (MethodInfo info in methods)
			{
				builder.Append($"{new DocType(info.ReturnType).Link} {info.Name}{Strings.FromArray(info.GetParameters().Select(s => $"{(s.IsIn ? "in " : "")}{(s.IsOut ? "out " : "")}{new DocType(s.ParameterType).Link} {s.Name}"), "(", ")")}\n  ");
				builder.Append("  \n");
				builder.Append(info.GetXmlDocsSummary() + "  \n");
			}
		}
		if (statMethods.Count() > 0)
		{
			builder.Append("## Static Methods\n");
			foreach (MethodInfo info in statMethods)
			{
				builder.Append($"{new DocType(info.ReturnType).Link} {info.Name}{Strings.FromArray(info.GetParameters().Select(s => $"{(s.IsIn ? "in " : "")}{(s.IsOut ? "out " : "")}{new DocType(s.ParameterType).Link} {s.Name}"), "(", ")")}\n  ");
				builder.Append("  \n"); 
				builder.Append(info.GetXmlDocsSummary() + "  \n");
			}
		}
		return builder.ToString();
	}
	public string GenDocCTORS()
	{
		ConstructorInfo[] ctors = type.GetConstructors();
		if (ctors.Length <= 0) return "";

		StringBuilder builder = new();
		
		builder.Append("## Constructors\n");
		foreach (ConstructorInfo info in ctors)
		{
			builder.Append("new ");
			builder.Append(NormalizedName);
			builder.Append(Strings.FromArray(info.GetParameters().Select(s => $"{new DocType(s.ParameterType).Link} {s.Name}"), "(", ")"));
			builder.Append("  \n");
		}
		return builder.ToString();
	}
	public string GenDocPROPS()
	{
		PropertyInfo[] props = type.GetProperties();
		PropertyInfo[] parentProps = type.BaseType?.GetProperties() ?? Array.Empty<PropertyInfo>();
		PropertyInfo[] newProps = props.Where(s => !parentProps.Contains(s)).ToArray();

		if (newProps.Length <= 0) return "";
		StringBuilder builder = new();

		builder.Append("## Properties\n");
		builder.Append("|Type|Name|Summary|\n");
		builder.Append("|:-:|:--:|:-|\n");
		foreach (PropertyInfo info in newProps)
		{
			builder.Append($"|{new DocType(info.PropertyType).Link}|{info.Name}|{info.GetXmlDocsSummary()}|\n");
		}

		return builder.ToString();
	}
	public string GenDocFIELDS()
	{
		FieldInfo[] fields = type.GetFields();
		FieldInfo[] parentFields = type.BaseType.GetFields();
		FieldInfo[] newFields = fields.Where(s => !parentFields.Contains(s)).ToArray();

		if (newFields.Length <= 0) return "";
		StringBuilder builder = new();

		builder.Append("## Fields\n");
		builder.Append("|Type|Name|Summary|\n");
		builder.Append("|:-:|:--:|:-|\n");
		foreach (FieldInfo info in newFields)
		{
			builder.Append($"|{new DocType(info.FieldType).Link}|{info.Name}|{info.GetXmlDocsSummary()}|\n");
		}

		return builder.ToString();
	}
	public string GenDocEnumINCODE()
	{
		StringBuilder builder = new();
		builder.Append("public enum ");
		builder.Append(GetNormalizedGenericNameBasic(type));
		builder.Append(" : ");
		builder.Append(new DocType(type.GetEnumUnderlyingType()).Name);
		builder.Append(" { }");
		return builder.ToString();
	}
	public string GenDocINCODE()
	{
		StringBuilder builder = new();
		if (type.IsClass)
		{
			builder.Append("public ");
			if (TypeAttr.HasFlag(TypeAttributes.Sealed))
			{
				builder.Append(TypeAttr.HasFlag(TypeAttributes.Abstract) ? "static " : "sealed ");
			} else if (TypeAttr.HasFlag(TypeAttributes.Abstract))
			{
				builder.Append("abstract ");
			}
			builder.Append("class ");
		}
		else if (type.IsInterface)
		{
			builder.Append("public interface ");
		}
		else if (type.IsEnum)
		{
			builder.Append("public enum ");
		}
		else if (type.IsValueType)
		{
			builder.Append("public ");
			if (type.GetFields().All(s => s.IsInitOnly)) builder.Append("readonly ");
			builder.Append("struct ");
		}
		builder.Append(GetNormalizedGenericNameBasic(type));
		builder.Append(" { }");
		return builder.ToString();
	}
	public TypeAttributes TypeAttr => GetAttributeFlagsImpl();
	private static string GetNormalizedGenericNameBasic(Type type)
	{
		StringBuilder builder = new();
		if (type.IsGenericType)
		{
			string realName = type.Name.Split('`').FirstOrDefault();
			builder.Append(realName);
			builder.Append(Strings.FromArray(
				type.GetGenericArguments()
				.Select(s => GetNormalizedGenericName(s))
				, "<", ">"));
		}
		else
		{
			builder.Append(type.Name);
		}
		return builder.ToString();
	}
	private static string GetNormalizedGenericName(Type type)
	{
		StringBuilder builder = new();
		if (type.IsGenericType)
		{
			string realName = type.Name.Split('`').FirstOrDefault();
			builder.Append(realName);
			builder.Append(Strings.FromArray(
				type.GetGenericArguments()
				.Select(s => GetNormalizedGenericName(s))
				, "{<}", "{>}"));
		}
		else
		{
			builder.Append(type.Name);
		}
		return builder.ToString();
	}
	#region Basic realization
	public override Assembly Assembly => type.Assembly;
	public override string AssemblyQualifiedName => type.AssemblyQualifiedName;
	public override Type BaseType => type.BaseType;
	public override string FullName => type.FullName;
	public override Guid GUID => type.GUID;
	public override Module Module => type.Module;
	public override string Namespace => type.Namespace;
	public override Type UnderlyingSystemType => type.UnderlyingSystemType;
	public override string Name => type.Name;
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) => type.GetConstructors(bindingAttr);
	public override object[] GetCustomAttributes(bool inherit) => type.GetCustomAttributes(inherit);
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) => type.GetCustomAttributes(attributeType, inherit);
	public override Type GetElementType() => type.GetElementType();
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) => type.GetEvent(name, bindingAttr);
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) => GetEvents(bindingAttr);
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) => type.GetField(name, bindingAttr);
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) => type.GetFields(bindingAttr);
	[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
	public override Type GetInterface(string name, bool ignoreCase) => type.GetInterface(name, ignoreCase);
	public override Type[] GetInterfaces() => type.GetInterfaces();
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) => type.GetMembers(bindingAttr);
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) => type.GetMethods(bindingAttr);
	public override Type GetNestedType(string name, BindingFlags bindingAttr) => type.GetNestedType(name, bindingAttr);
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) => type.GetNestedTypes(bindingAttr);
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) => type.GetProperties(bindingAttr);
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) => type.InvokeMember(name, invokeAttr, binder, target, args);
	public override bool IsDefined(Type attributeType, bool inherit) => type.IsDefined(type, inherit);
	protected override TypeAttributes GetAttributeFlagsImpl() => type.GetTypeInfo().Attributes;
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => throw new NotImplementedException();
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => throw new NotImplementedException();
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) => throw new NotImplementedException();
	protected override bool HasElementTypeImpl() => throw new NotImplementedException();
	protected override bool IsArrayImpl() => throw new NotImplementedException();
	protected override bool IsByRefImpl() => throw new NotImplementedException();
	protected override bool IsCOMObjectImpl() => throw new NotImplementedException();
	protected override bool IsPointerImpl() => throw new NotImplementedException();
	protected override bool IsPrimitiveImpl() => throw new NotImplementedException();
	#endregion
}
