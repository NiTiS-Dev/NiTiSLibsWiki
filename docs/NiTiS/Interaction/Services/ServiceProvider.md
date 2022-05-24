# ServiceProvider Class
## Definition

###### Namepsace: [NiTiS.Interaction.Services](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Interaction.Services)
###### Assembly: NiTiS.Interaction.dll

#### 
```c#
public class ServiceProvider { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [ServiceProvider](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Interaction/Services/ServiceProvider)  
#### Implements [IServiceProvider](https://docs.microsoft.com/dotnet/api/system.iserviceprovider)

<br>

## Constructors
new ServiceProvider()  
  
  
  
## Methods
[T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Interaction/Services/T) GetService([Type](https://docs.microsoft.com/dotnet/api/system.type) serviceType)
    
  
[Object](https://docs.microsoft.com/dotnet/api/system.object) GetService([Type](https://docs.microsoft.com/dotnet/api/system.type) serviceType)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) TryGetService([Type](https://docs.microsoft.com/dotnet/api/system.type) serviceType, out [Object&](https://docs.microsoft.com/dotnet/api/system.object&) service)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) TryGetService(out [T&](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Interaction/Services/T&) service)
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Exists()
    
  
[Boolean](https://docs.microsoft.com/dotnet/api/system.boolean) Exists([Type](https://docs.microsoft.com/dotnet/api/system.type) serviceType)
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) AddService([T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Interaction/Services/T) service)
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) AddService([Type](https://docs.microsoft.com/dotnet/api/system.type) type, [Object](https://docs.microsoft.com/dotnet/api/system.object) service)
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

[T](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Interaction/Services/T) GetRequiredService()  

  
