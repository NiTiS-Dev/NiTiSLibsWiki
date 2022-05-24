# File Class
## Definition

###### Namepsace: [NiTiS.IO](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.IO)
###### Assembly: NiTiS.IO.dll

#### Provides methods for action with existing file
```c#
public sealed class File { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [Path](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Path) &#8594; [File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File)  
#### Implements [IStorageElement](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/IStorageElement)

<br>

## Constructors
new File([String](https://docs.microsoft.com/dotnet/api/system.string)[] path)  
new File([Directory](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Directory) parent, [String](https://docs.microsoft.com/dotnet/api/system.string) fileName)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[String](https://docs.microsoft.com/dotnet/api/system.string)|Path||
|[MemorySize](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/MemorySize)|Size||
|[String](https://docs.microsoft.com/dotnet/api/system.string)|Name||
|[String](https://docs.microsoft.com/dotnet/api/system.string)|NameWithoutExtension|Name of the element (extension exclude)|
|[String](https://docs.microsoft.com/dotnet/api/system.string)|Extension|Extension of the file|
|[Directory](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/Directory)|Parent|Directory where located this file|
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|CreationTime||
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|LastAccessTime||
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|CreationTimeUTC||
|[DateTime](https://docs.microsoft.com/dotnet/api/system.datetime)|LastAccessTimeUTC||
|[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean)|Exists||
  
  
## Methods
[Void](https://docs.microsoft.com/dotnet/api/system.void) Rename([String](https://docs.microsoft.com/dotnet/api/system.string) newName, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Renaming the file  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Create([Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) createSubDirectory)
    
Create file if not exists  
[FileStream](https://docs.microsoft.com/dotnet/api/system.io.filestream) OpenForRead()
    
Returns the stream to read the file  
[FileStream](https://docs.microsoft.com/dotnet/api/system.io.filestream) OpenForWrite()
    
Returns the stream to write the file  
[FileStream](https://docs.microsoft.com/dotnet/api/system.io.filestream) Open([OpenType](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/OpenType) openType, [FileAccess](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/FileAccess) access)
    
Returns the stream by options  
[Void](https://docs.microsoft.com/dotnet/api/system.void) CopyTo([String](https://docs.microsoft.com/dotnet/api/system.string) path, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Copies data from a file to another file
(if the file does not exist, it will create a new one)  
[Void](https://docs.microsoft.com/dotnet/api/system.void) CopyTo([File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) copyTo, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Copies data from a file to another file
(if the file does not exist, it will create a new one)  
[Void](https://docs.microsoft.com/dotnet/api/system.void) MoveTo([String](https://docs.microsoft.com/dotnet/api/system.string) path, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Move file to other space  
[Void](https://docs.microsoft.com/dotnet/api/system.void) MoveTo([File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) moveTo, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Move file to other space  
[File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) CreateBackupFile([String](https://docs.microsoft.com/dotnet/api/system.string) path, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) copy)
    
Create backup file from existing file  
[Byte](https://docs.microsoft.com/dotnet/api/system.byte)[] ReadBytes()
    
Read a file as byte array  
[String](https://docs.microsoft.com/dotnet/api/system.string) ReadText()
    
Read a file as string  
[Void](https://docs.microsoft.com/dotnet/api/system.void) WriteBytes([Byte](https://docs.microsoft.com/dotnet/api/system.byte)[] bytes)
    
Write byte array to file  
[Void](https://docs.microsoft.com/dotnet/api/system.void) WriteText([String](https://docs.microsoft.com/dotnet/api/system.string) value)
    
Write string to file  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Replace([File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) destinationFile, [File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) destinationBackupFile)
    
Swap files values  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Delete()
    
Delete current file from storage  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) CopyToAsync([String](https://docs.microsoft.com/dotnet/api/system.string) path, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Copies data from a file to another file asynchronously
(if the file does not exist, it will create a new one)  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) CopyToAsync([File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) copyTo, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Copies data from a file to another file asynchronously
(if the file does not exist, it will create a new one)  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) MoveToAsync([String](https://docs.microsoft.com/dotnet/api/system.string) path, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Move file to other space asynchronously  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) MoveToAsync([File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) moveTo, [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) overwrite)
    
Move file to other space asynchronously  
[Task&#60;File&#62;](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1) CreateBackupFileAsync([String](https://docs.microsoft.com/dotnet/api/system.string) path)
    
Create backup file from existing file asynchronously  
[Task&#60;Byte[]&#62;](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1) ReadBytesAsync([CancellationToken](https://docs.microsoft.com/dotnet/api/system.threading.cancellationtoken) cancellationToken)
    
Read a file as byte array asynchronously  
[Task&#60;String&#62;](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1) ReadTextAsync([CancellationToken](https://docs.microsoft.com/dotnet/api/system.threading.cancellationtoken) cancellationToken)
    
Read a file as string asynchronously  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) WriteBytesAsync([Byte](https://docs.microsoft.com/dotnet/api/system.byte)[] bytes, [CancellationToken](https://docs.microsoft.com/dotnet/api/system.threading.cancellationtoken) cancellationToken)
    
Write byte array to file asynchronously  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) WriteTextAsync([String](https://docs.microsoft.com/dotnet/api/system.string) value, [CancellationToken](https://docs.microsoft.com/dotnet/api/system.threading.cancellationtoken) cancellationToken)
    
Write string to file asynchronously  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) ReplaceAsync([File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) destinationFile, [File](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/IO/File) destinationBackupFile)
    
Swap files values asynchronously  
[Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task) DeleteAsync()
    
Delete current file from storage asynchronously  
[Void](https://docs.microsoft.com/dotnet/api/system.void) ThrowIfNotExists()
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) ToString()
    
  
[String](https://docs.microsoft.com/dotnet/api/system.string) GetDebuggerDisplay()
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) <DeleteAsync>b__54_0()
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

  
