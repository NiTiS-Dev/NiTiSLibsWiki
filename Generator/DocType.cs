using NiTiS.Additions;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Generator;

public sealed class DocType : Type
{
	private readonly Type type;
	public DocType(Type type) => this.type = type;
	public string NormalizedName => GetNormalizedGenericName(this.type);
	public TypeAttributes TypeAttr => GetAttributeFlagsImpl();
	public static string GetNormalizedGenericName(Type type)
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
