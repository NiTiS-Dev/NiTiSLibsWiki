# Vector3DInt Structure
## Definition

###### Namepsace: [NiTiS.Math.Vectors](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Math.Vectors)
###### Assembly: NiTiS.Math.dll

#### 
```c#
public readonly struct Vector3DInt { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [ValueType](https://docs.microsoft.com/dotnet/api/system.valuetype) &#8594; [Vector3DInt](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Vectors/Vector3DInt)  
#### Implements [IVector&#60;Int32&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Vectors/IVector-1), [IVector](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Vectors/IVector), [ISerializable](https://docs.microsoft.com/dotnet/api/system.runtime.serialization.iserializable), [IEquatable&#60;Vector3DInt&#62;](https://docs.microsoft.com/dotnet/api/system.iequatable-1), [IEquatable&#60;Vector3D&#62;](https://docs.microsoft.com/dotnet/api/system.iequatable-1)

<br>

## Constructors
new Vector3DInt([Int32](https://docs.microsoft.com/dotnet/api/system.int32) x, [Int32](https://docs.microsoft.com/dotnet/api/system.int32) y, [Int32](https://docs.microsoft.com/dotnet/api/system.int32) z)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[Double](https://docs.microsoft.com/dotnet/api/system.double)|LengthSquared||
|[Double](https://docs.microsoft.com/dotnet/api/system.double)|Length||
  
## Fields
|Type|Name|Summary|
|:-:|:--:|:-|
|[Int32](https://docs.microsoft.com/dotnet/api/system.int32)|x||
|[Int32](https://docs.microsoft.com/dotnet/api/system.int32)|y||
|[Int32](https://docs.microsoft.com/dotnet/api/system.int32)|z||
  
## Methods
[Int32](https://docs.microsoft.com/dotnet/api/system.int32) GetValueByDimension([Axis](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Axis) axis)
    
  
[Vector3DInt](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Vectors/Vector3DInt) Normalize()
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString()
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) GetObjectData([SerializationInfo](https://docs.microsoft.com/dotnet/api/system.runtime.serialization.serializationinfo) info, [StreamingContext](https://docs.microsoft.com/dotnet/api/system.runtime.serialization.streamingcontext) context)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Vector3DInt](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Vectors/Vector3DInt) other)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Vector3D](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Math/Vectors/Vector3D) other)
    
  
[Int32](https://docs.microsoft.com/dotnet/api/system.int32) GetHashCode()
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Equals([Object](https://docs.microsoft.com/dotnet/api/system.object) obj)
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
