# SmartDictonary&#60;TKey, TValue&#62; Class
## Definition

###### Namepsace: [NiTiS.Collections.Generic](https://nitis-dev.github.io/NiTiSLibsWiki/Namespaces/NiTiS.Collections.Generic)
###### Assembly: NiTiS.Collections.dll

#### 
```c#
public class SmartDictonary<TKey, TValue> { }
```
#### Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) &#8594; [Dictionary&#60;TKey, TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.dictionary-2) &#8594; [SmartDictonary&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/SmartDictonary-2)  
#### Implements [IDictionary&#60;TKey, TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2), [ICollection&#60;KeyValuePair&#60;TKey, TValue&#62;&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.icollection-1), [IEnumerable&#60;KeyValuePair&#60;TKey, TValue&#62;&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable), [IDictionary](https://docs.microsoft.com/dotnet/api/system.collections.idictionary), [ICollection](https://docs.microsoft.com/dotnet/api/system.collections.icollection), [IReadOnlyDictionary&#60;TKey, TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary-2), [IReadOnlyCollection&#60;KeyValuePair&#60;TKey, TValue&#62;&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1), [ISerializable](https://docs.microsoft.com/dotnet/api/system.runtime.serialization.iserializable), [IDeserializationCallback](https://docs.microsoft.com/dotnet/api/system.runtime.serialization.ideserializationcallback)

<br>

## Constructors
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [IDictionary&#60;TKey, TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2) dictionary)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [IDictionary&#60;TKey, TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2) dictionary, [IEqualityComparer&#60;TKey&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1) comparer)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [Int32](https://docs.microsoft.com/dotnet/api/system.int32) capacity)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [Int32](https://docs.microsoft.com/dotnet/api/system.int32) capacity, [IEqualityComparer&#60;TKey&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1) comparer)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [IEnumerable&#60;KeyValuePair&#60;TKey, TValue&#62;&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) collection)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [IEnumerable&#60;KeyValuePair&#60;TKey, TValue&#62;&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) collection, [IEqualityComparer&#60;TKey&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1) comparer)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [IEnumerable&#60;TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) collection)  
new SmartDictonary&#60;TKey, TValue&#62;([KeyGetter&#60;TKey, TValue&#62;](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/KeyGetter) keyGetter, [IEnumerable&#60;TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) collection, [IEqualityComparer&#60;TKey&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1) comparer)  
  
## Properties
|Type|Name|Summary|
|:-:|:--:|:-|
|[IEqualityComparer&#60;TKey&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1)|Comparer||
|[Int32](https://docs.microsoft.com/dotnet/api/system.int32)|Count||
|[KeyCollection&#60;TKey, TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.keycollection)|Keys||
|[ValueCollection&#60;TKey, TValue&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.valuecollection)|Values||
|[TValue](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/TValue)|Item||
  
  
## Methods
[Void](https://docs.microsoft.com/dotnet/api/system.void) Add([TValue](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/TValue) value)
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Remove([TValue](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/TValue) value)
    
  
[Void](https://docs.microsoft.com/dotnet/api/system.void) Remove([TValue](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/TValue) value, out [TKey&](https://nitis-dev.github.io/NiTiSLibsWiki/NiTiS/Collections/Generic/TKey&) key)
    
  
  
## Extension Methods
[Byte&](https://docs.microsoft.com/dotnet/api/system.byte&) GetRawData()  

[IEnumerable&#60;TResult&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) OfType()  

[IEnumerable&#60;TResult&#62;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) Cast()  

  
