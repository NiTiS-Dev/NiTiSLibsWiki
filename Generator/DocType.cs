using System;
using System.Linq;
using SType = System.Type;

public class DocType
{
    public SType Type { get; private set; }
    public DocType(SType type) => this.Type = type;
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
            text += Type.IsSealed ? "sealed " : "";
            text += Type.IsAbstract ? "abstract " : "";
            text += Type.IsValueType ? "struct " : "class ";
        }
        return text;
    }
    public string Namespace => this.Type?.Namespace ?? "";
    public string ClearName => GetNameByType(this.Type);
    public string Name => GetNameByType(this.Type);
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
            return type.Name + GetGenericNames(type.GenericTypeArguments);
        }
        else
        {
            return type.Name;
        }
    }
    public static string GetNameByType(SType type) => type.Name;
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