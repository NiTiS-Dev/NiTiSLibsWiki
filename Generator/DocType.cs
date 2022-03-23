using System;
using System.Linq;

public class DocType
{
    public Type Type { get; private set; }
    public DocType(Type type) => this.Type = type;
    public string Namespace => this.Type?.Namespace ?? "";
    public string ClearName => GetNameByType(this.Type);
    public Template TemplateType {
        get {
            if (Type.IsInterface) return Template.Interface;
            if (Type.IsValueType) return Template.Struct;
            if (Type.IsEnum) return Template.Enum;
            return Template.Class;
        } 
    }

    public static string GetNameByType(Type type)
    {
        if (type.IsGenericType)
        {
            return String.Concat(type.Name.Split('`').SkipLast(1)) + GetGenericNames(type.GetGenericArguments());
        }
        else
        {
            return type.Name;
        }
    }
    public static string GetGenericNames(Type[] generics)
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