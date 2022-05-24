# Sequence&#60;T&#62; Class
## Definition

###### Namepsace: [NiTiS.Collections.Generic](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Collections.Generic)
###### Assembly: NiTiS.Collections.dll

#### 
```c#
public class Sequence<T> { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [Sequence&#60;T&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/Sequence-1)  
#### Implements [IEnumerable&#60;T&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable)

<br>

## Constructors
new Sequence&#60;T&#62;()  
new Sequence&#60;T&#62;([UInt64](https://docs.microsoft.com/dotnet/api/system.uint64) size)  
new Sequence&#60;T&#62;([IEqualityComparer&#60;T&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1) equalityComparer)  
new Sequence&#60;T&#62;([UInt64](https://docs.microsoft.com/dotnet/api/system.uint64) startSize, [IEqualityComparer&#60;T&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1) equalityComparer)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[UInt64](https://docs.microsoft.com/dotnet/api/system.uint64)|Length||
|[UInt64](https://docs.microsoft.com/dotnet/api/system.uint64)|LengthLimit||
|[T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/T)|Item||
  
  
## Methods
[Void](https://docs.microsoft.com/dotnet/api/system.void) Add([T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/T) item)
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) AddRange([T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/T)[] items)
    
  
[UInt64](https://docs.microsoft.com/dotnet/api/system.uint64) IndexOf([T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/T) item)
    
  
[T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/T) GetValue([UInt64](https://docs.microsoft.com/dotnet/api/system.uint64) index)
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) CheckArray()
    
  
[IEnumerator&#60;T&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1) GetEnumerator()
    
  
[IEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerator) System.Collections.IEnumerable.GetEnumerator()
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString()
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) GetDebuggerDisplay()
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

[IEnumerable&#60;TResult&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) OfType()  

[IEnumerable&#60;TResult&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) Cast()  

  
