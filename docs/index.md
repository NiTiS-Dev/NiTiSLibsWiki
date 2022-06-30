# NiTiS Core Wiki
This wiki is hosted on GitHub. 
If you would like to edit something, 
simply click the edit button at the top of a page, 
and you will be directed to a pull request form, 
where you can make your changes and submit them for approval (doesnt works with auto-generated pages). 
## Links
+ [Nuget](https://www.nuget.org/packages/NiTiSCore)
+ [Github](https://www.github.com/NiTiS-Dev/NiTiSCore)
+ [Open a issue](https://github.com/NiTiS-Dev/NiTiSCore/issues/new/choose)
+ [Releases](https://github.com/NiTiS-Dev/NiTiSCore/releases)
## Usage in project
```xml
<Project>
  ...
  <ItemGroup>
    <!-- Usage all NiTiS modules -->
    <PackageReference Include="NiTiSCore" Version="PUT VERSION HERE" />
    <!-- Usage certain NiTiS modules -->
    <PackageReference Include="NiTiS.IO" Version="PUT VERSION HERE" />
    <PackageReference Include="NiTiS.Reflection" Version="PUT VERSION HERE" />
  </ItemGroup>
  ...
</Project>
```
