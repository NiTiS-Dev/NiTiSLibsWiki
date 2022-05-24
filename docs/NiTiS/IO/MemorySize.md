# MemorySize Structure
## Definition

###### Namepsace: [NiTiS.IO](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.IO)
###### Assembly: NiTiS.IO.dll

#### 
```c#
public readonly struct MemorySize { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [ValueType](https://docs.microsoft.com/dotnet/api/system.valuetype) &#8594; [MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)  
#### Implements [IEquatable&#60;MemorySize&#62;](https://docs.microsoft.com/dotnet/api/system.iequatable-1), [IEquatable&#60;Int64&#62;](https://docs.microsoft.com/dotnet/api/system.iequatable-1), [IComparable&#60;MemorySize&#62;](https://docs.microsoft.com/dotnet/api/system.icomparable-1), [IComparable&#60;Int64&#62;](https://docs.microsoft.com/dotnet/api/system.icomparable-1), [IFormattable](https://docs.microsoft.com/dotnet/api/system.iformattable)

<br>

## Constructors
new MemorySize([Int64](https://docs.microsoft.com/dotnet/api/system.int64) bytes)  
new MemorySize([Int64](https://docs.microsoft.com/dotnet/api/system.int64) size, [SizeFormat](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/SizeFormat) format)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Zero||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Byte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Kilobyte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Megabyte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Gigabyte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Terabyte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Kibibyte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Mebibyte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Gibibyte||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Tebibyte||
  
## Fields
|Type|Name|Summary|
|:-:|:--:|:-|
|[Int64](https://docs.microsoft.com/dotnet/api/system.int64)|bytes||
  
## Methods
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString()
    
  
[Decimal](https://docs.microsoft.com/dotnet/api/system.decimal) GetByFormat([SizeFormat](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/SizeFormat) format)
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString([String](https://docs.microsoft.com/dotnet/api/system.string) format)
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString([String](https://docs.microsoft.com/dotnet/api/system.string) format, [IFormatProvider](https://docs.microsoft.com/dotnet/api/system.iformatprovider) formatProvider)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Object](https://docs.microsoft.com/dotnet/api/system.object) obj)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Int64](https://docs.microsoft.com/dotnet/api/system.int64) bytes)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize) size)
    
  
[Int32](https://docs.microsoft.com/dotnet/api/system.int32) CompareTo([Int64](https://docs.microsoft.com/dotnet/api/system.int64) other)
    
  
[Int32](https://docs.microsoft.com/dotnet/api/system.int32) CompareTo([MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize) other)
    
  
[Int32](https://docs.microsoft.com/dotnet/api/system.int32) GetHashCode()
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
