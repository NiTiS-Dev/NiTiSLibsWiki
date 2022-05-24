# Cast&#60;T, TOut&#62; Class
## Definition

###### Namepsace: [NiTiS.Additions](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Additions)
###### Assembly: NiTiS.Additions.dll

#### 
```c#
public sealed class Cast<T, TOut> { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [Delegate](https://docs.microsoft.com/dotnet/api/system.delegate) &#8594; [MulticastDelegate](https://docs.microsoft.com/dotnet/api/system.multicastdelegate) &#8594; [Cast&#60;T, TOut&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Cast-2)  
#### Implements [ICloneable](https://docs.microsoft.com/dotnet/api/system.icloneable), [ISerializable](https://docs.microsoft.com/dotnet/api/system.runtime.serialization.iserializable)

<br>

## Constructors
new Cast&#60;T, TOut&#62;([Object](https://docs.microsoft.com/dotnet/api/system.object) object, [IntPtr](https://docs.microsoft.com/dotnet/api/system.intptr) method)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[Object](https://docs.microsoft.com/dotnet/api/system.object)|Target||
|[MethodInfo](https://docs.microsoft.com/dotnet/api/system.reflection.methodinfo)|Method||
  
  
## Methods
[TOut](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/TOut) Invoke([T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T) item)
    
  
[IAsyncResult](https://docs.microsoft.com/dotnet/api/system.iasyncresult) BeginInvoke([T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/T) item, [AsyncCallback](https://docs.microsoft.com/dotnet/api/system.asynccallback) callback, [Object](https://docs.microsoft.com/dotnet/api/system.object) object)
    
  
[TOut](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/TOut) EndInvoke([IAsyncResult](https://docs.microsoft.com/dotnet/api/system.iasyncresult) result)
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

[MethodInfo](https://docs.microsoft.com/dotnet/api/system.reflection.methodinfo) GetMethodInfo()  

  
