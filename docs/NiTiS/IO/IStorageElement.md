# IStorageElement Interface
## Definition

###### Namepsace: [NiTiS.IO](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.IO)
###### Assembly: NiTiS.IO.dll

#### 
```c#
public interface IStorageElement { }
```
#### 

<br>

## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[String](https://docs.microsoft.com/dotnet/api/system.string)|Name|Name of the element|
|[String](https://docs.microsoft.com/dotnet/api/system.string)|Path|Return path to the object|
|[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean)|Exists|Return true when object exists|
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|CreationTime|Time when element is created|
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|LastAccessTime|Time when element is last accessible|
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|CreationTimeUTC|Time when element is created (UTC)|
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|LastAccessTimeUTC|Time when element is last accessible(UTC)|
  
## Methods
[Void](https://docs.microsoft.com/dotnet/api/system.void) ThrowIfNotExists()
    
Throws  when file not exists  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
