# SmartIterator&#60;T&#62; Structure
## Definition

###### Namepsace: [NiTiS.Additions](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Additions)
###### Assembly: NiTiS.Additions.dll

#### 
```c#
public readonly struct SmartIterator<T> { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [ValueType](https://docs.microsoft.com/dotnet/api/system.valuetype) &#8594; [SmartIterator&#60;T&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/SmartIterator-1)  
#### Implements [IEquatable&#60;SmartIterator&#60;T&#62;&#62;](https://docs.microsoft.com/dotnet/api/system.iequatable-1)

<br>

## Constructors
new SmartIterator&#60;T&#62;([Validator&#60;T&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Validator-1) Validator, [Iterator&#60;T&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Iterator-1) Iterator)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[Validator&#60;T&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Validator-1)|Validator||
|[Iterator&#60;T&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Iterator-1)|Iterator||
  
  
## Methods
[IEnumerable&#60;T&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) Iterate([IEnumerable&#60;T&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) enumerable)
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString()
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) PrintMembers([StringBuilder](https://docs.microsoft.com/dotnet/api/system.text.stringbuilder) builder)
    
  
[Int32](https://docs.microsoft.com/dotnet/api/system.int32) GetHashCode()
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Object](https://docs.microsoft.com/dotnet/api/system.object) obj)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([SmartIterator&#60;T&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/SmartIterator-1) other)
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Deconstruct(out [Validator`1&](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Validator-1&) Validator, out [Iterator`1&](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Additions/Iterator-1&) Iterator)
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
