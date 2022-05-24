# Directory Class
## Definition

###### Namepsace: [NiTiS.IO](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.IO)
###### Assembly: NiTiS.IO.dll

#### Presentation of some directory
```c#
public sealed class Directory { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [Path](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Path) &#8594; [Directory](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Directory)  
#### Implements [IStorageElement](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/IStorageElement)

<br>

## Constructors
new Directory([String](https://docs.microsoft.com/dotnet/api/system.string)[] path)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[String](https://docs.microsoft.com/dotnet/api/system.string)|Path||
|[String](https://docs.microsoft.com/dotnet/api/system.string)|Name||
|[Directory](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Directory)|Parent|Directory where located this directory|
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|CreationTime||
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|LastAccessTime||
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|CreationTimeUTC||
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|LastAccessTimeUTC||
|[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean)|Exists||
  
  
## Methods
[Void](https://docs.microsoft.com/dotnet/api/system.void) Rename([String](https://docs.microsoft.com/dotnet/api/system.string) newName, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Renaming the directory  
[String](https://docs.microsoft.com/dotnet/api/system.string)[] Separate()
    
Returns path separated by folders  
[Directory](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Directory)[] GetNearbyDirectories([Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) selfInclude)
    
Get other folders from this directory  
[File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File)[] GetFiles()
    
Get internal files  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Create()
    
Create dictonary if not exists  
[Directory](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Directory)[] GetDirectories()
    
Get internal directories  
[Void](https://docs.microsoft.com/dotnet/api/system.void) ThrowIfNotExists()
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Delete([Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) recursive)
    
Delete current file from storage  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Delete()
    
Delete current file from storage  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString()
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) GetDebuggerDisplay()
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
