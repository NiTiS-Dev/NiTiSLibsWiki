# Class Class
## Definition

###### Namepsace: [NiTiS.Reflection](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Reflection)
###### Assembly: NiTiS.Reflection.dll

#### 
```c#
public class Class { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [Class](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/Class)  
#### 

<br>

## Constructors
new Class([Type](https://docs.microsoft.com/dotnet/api/system.type) type)  
new Class([Object](https://docs.microsoft.com/dotnet/api/system.object) itm)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[Type](https://docs.microsoft.com/dotnet/api/system.type)|Type||
|[FieldList](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/FieldList)|Fields||
|[FieldList](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/FieldList)|StaticFields||
|[PropertyList](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/PropertyList)|Properties||
|[PropertyList](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/PropertyList)|StaticProperties||
|[MethodList](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/MethodList)|Methods||
|[MethodList](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/MethodList)|StaticMethods||
|[ConstructorList](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/ConstructorList)|Constructors||
  
  
## Methods
[FieldInfo](https://docs.microsoft.com/dotnet/api/system.reflection.fieldinfo) GetField([Environment](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/Environment) env, [String](https://docs.microsoft.com/dotnet/api/system.string) name)
    
  
[PropertyInfo](https://docs.microsoft.com/dotnet/api/system.reflection.propertyinfo) GetProperty([Environment](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/Environment) env, [String](https://docs.microsoft.com/dotnet/api/system.string) name)
    
  
[MethodInfo](https://docs.microsoft.com/dotnet/api/system.reflection.methodinfo) GetMethod([Environment](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/Environment) env, [String](https://docs.microsoft.com/dotnet/api/system.string) name)
    
  
[IEnumerable&#60;FieldInfo&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) GetFields([Environment](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/Environment) env)
    
  
[IEnumerable&#60;PropertyInfo&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) GetProperties([Environment](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/Environment) env)
    
  
[IEnumerable&#60;MethodInfo&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) GetMethods([Environment](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Reflection/Environment) env)
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
