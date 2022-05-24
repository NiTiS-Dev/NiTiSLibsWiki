# Validator&#60;T1, T2, T3&#62; Class
## Definition

###### Namepsace: [NiTiS.Additions](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Additions)
###### Assembly: NiTiS.Additions.dll

#### 
```c#
public sealed class Validator<T1, T2, T3> { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [Delegate](https://docs.microsoft.com/dotnet/api/system.delegate) &#8594; [MulticastDelegate](https://docs.microsoft.com/dotnet/api/system.multicastdelegate) &#8594; [Validator&#60;T1, T2, T3&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Validator-3)  
#### Implements [ICloneable](https://docs.microsoft.com/dotnet/api/system.icloneable), [ISerializable](https://docs.microsoft.com/dotnet/api/system.runtime.serialization.iserializable)

<br>

## Constructors
new Validator&#60;T1, T2, T3&#62;([Object](https://docs.microsoft.com/dotnet/api/system.object) object, [IntPtr](https://docs.microsoft.com/dotnet/api/system.intptr) method)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[Object](https://docs.microsoft.com/dotnet/api/system.object)|Target||
|[MethodInfo](https://docs.microsoft.com/dotnet/api/system.reflection.methodinfo)|Method||
  
  
## Methods
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Invoke([T1](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T1) item1, [T2](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T2) item2, [T3](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T3) item3)
    
  
[IAsyncResult](https://docs.microsoft.com/dotnet/api/system.iasyncresult) BeginInvoke([T1](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T1) item1, [T2](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T2) item2, [T3](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T3) item3, [AsyncCallback](https://docs.microsoft.com/dotnet/api/system.asynccallback) callback, [Object](https://docs.microsoft.com/dotnet/api/system.object) object)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) EndInvoke([IAsyncResult](https://docs.microsoft.com/dotnet/api/system.iasyncresult) result)
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

[MethodInfo](https://docs.microsoft.com/dotnet/api/system.reflection.methodinfo) GetMethodInfo()  

  
