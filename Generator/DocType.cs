using NiTiS.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using SType = System.Type;

public class DocType
{
    public SType Type { get; private set; }
    public DocType(SType type) => this.Type = type;
    public string GenerateProps()
    {
        StringBuilder builder = new StringBuilder();
        InstanceEditor editor = new(Type);
        InstanceEditor editorObj = new(new object());
        List<string> skipList = new();
        foreach(var i in editorObj.GetProperityEnumerable())
        {
            skipList.Add(i.Name);
        }

        foreach (var v in editor.GetProperityEnumerable())
        {
            if (skipList.Contains(v.Name)) continue;
            string get = GetModifer(v.GetGetMethod());
            string set = GetModifer(v.GetSetMethod());
            if (get is null && set is null) continue;
            builder.Append($"|{GetNameWithGenerics(v.PropertyType)}|{v.Name}|{get ?? "none"}|{set ?? "none"}|\n");
        }

        return builder.ToString();
    }
    public string GenerateFields()
    {
        StringBuilder builder = new();
        InstanceEditor editor = new(Type);
        foreach(FieldInfo i in editor.GetVariableEnumerable())
        {
            if(i.GetCustomAttribute<CompilerGeneratedAttribute>() is not null)
            {
                Console.WriteLine($"Skip Compiler Field {i.Name}");
                continue;
            }
            if (i.Name.StartsWith("m_")) continue;
            if (i.FieldType.Name == "RuntimeType" || i.Name == "GenericParameterCountAny") continue;
            builder.Append($"|{GetModifer(i)}|{i.FieldType}|{i.Name}|\n");
        }
        return builder.ToString();
    }
    public string GetModifer(MethodInfo member)
    {
        if (member is null) return null;
        if (member.Attributes.HasFlag(MethodAttributes.Private)) return "private";
        if (member.Attributes.HasFlag(MethodAttributes.Public)) return "public";
        if (member.Attributes.HasFlag(MethodAttributes.Family)) return "protected";
        return "hiden";
    }
    public string GetModifer(FieldInfo member)
    {
        if (member.Attributes.HasFlag(FieldAttributes.Private)) return "private";
        if (member.Attributes.HasFlag(FieldAttributes.Public)) return "public";
        if (member.Attributes.HasFlag(FieldAttributes.Family)) return "protected";
        return "hiden";
    }
    public string GenerateIncode()
    {
        return GenerateModifers() + GetNameWithGenerics(this.Type);
    }
    public string GenerateModifers()
    {
        string text = "";
        text += Type.IsNotPublic ? "private " : "";
        text += Type.IsPublic ? "public " : "";
        if (Type.IsInterface)
        {
            text += "interface ";
        }
        else
        {
            if (Type.IsSealed)
            {
                text += "sealed ";
            }
            else
            {
                text += Type.IsAbstract ? "abstract " : "";
            }
            text += Type.IsValueType ? "struct " : "class ";
        }
        return text;
    }
    public string Namespace => this.Type?.Namespace ?? "";
    public string ClearName => GetNameByType(this.Type);
    public string Name => GetNameWithGenerics(this.Type);
    public string FullClearName => $"{Namespace}.{ClearName}";
    public string FullName => $"{Namespace}.{Name}";
    public Template TemplateType
    {
        get
        {
            if (Type.IsInterface) return Template.Interface;
            if (Type.IsValueType) return Template.Struct;
            if (Type.IsEnum) return Template.Enum;
            return Template.Class;
        }
    }
    public static string GetNameWithGenerics(SType type)
    {
        if (type.IsGenericType)
        {
            return GetNameByType(type) + GetGenericNames(type.GetGenericArguments());
        }
        else
        {
            return GetNameByType(type);
        }
    }
    public static string GetNameByType(SType type)
    {
        if (type.IsGenericType)
        {
            return String.Concat(type.Name.Split('`').SkipLast(1));
        }
        return type.Name;
    }
    public static string GetGenericNames(SType[] generics)
    {
        string text = "";
        foreach (var type in generics)
        {
            if (String.IsNullOrEmpty(text)) text = type.Name;
            else text += ", " + type.Name;
        }
        return "<" + text + ">";
    }
}