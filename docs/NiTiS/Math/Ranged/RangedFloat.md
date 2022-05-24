# RangedFloat Structure
## Definition

###### Namepsace: [NiTiS.Math.Ranged](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Math.Ranged)
###### Assembly: NiTiS.Math.dll

#### 
```c#
public readonly struct RangedFloat { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [ValueType](https://docs.microsoft.com/dotnet/api/system.valuetype) &#8594; [RangedFloat](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Ranged/RangedFloat)  
#### Implements [IRangedVar&#60;Single&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Ranged/IRangedVar-1), [IEquatable&#60;RangedFloat&#62;](https://docs.microsoft.com/dotnet/api/system.iequatable-1), [IEquatable&#60;Single&#62;](https://docs.microsoft.com/dotnet/api/system.iequatable-1)

<br>

## Constructors
new RangedFloat([Single](https://docs.microsoft.com/dotnet/api/system.single) value, [Single](https://docs.microsoft.com/dotnet/api/system.single) min, [Single](https://docs.microsoft.com/dotnet/api/system.single) max)  
new RangedFloat([Int32](https://docs.microsoft.com/dotnet/api/system.int32) value, [Int32](https://docs.microsoft.com/dotnet/api/system.int32) min, [Int32](https://docs.microsoft.com/dotnet/api/system.int32) max)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[Single](https://docs.microsoft.com/dotnet/api/system.single)|MaxValue||
|[Single](https://docs.microsoft.com/dotnet/api/system.single)|MinValue||
|[Single](https://docs.microsoft.com/dotnet/api/system.single)|Value||
  
  
## Methods
[Void](https://docs.microsoft.com/dotnet/api/system.void) SetValue([Single](https://docs.microsoft.com/dotnet/api/system.single) value)
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString()
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Object](https://docs.microsoft.com/dotnet/api/system.object) obj)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([RangedFloat](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Ranged/RangedFloat) other)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Single](https://docs.microsoft.com/dotnet/api/system.single) other)
    
  
[Int32](https://docs.microsoft.com/dotnet/api/system.int32) GetHashCode()
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
