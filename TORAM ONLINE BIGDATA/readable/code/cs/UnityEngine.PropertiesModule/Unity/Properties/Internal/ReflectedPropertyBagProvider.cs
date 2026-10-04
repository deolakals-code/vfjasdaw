// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagProvider // TypeDefIndex: 17426
{
	// Fields
	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Methods

	// RVA: 0x38214F8 Offset: 0x381D4F8 VA: 0x38214F8
	public void .ctor() { }

	// RVA: 0x3821904 Offset: 0x381D904 VA: 0x3821904
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E5548 Offset: 0x26E1548 VA: 0x26E5548
	|-ReflectedPropertyBagProvider.CreatePropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E53E0 Offset: 0x26E13E0 VA: 0x26E53E0
	|-ReflectedPropertyBagProvider.CreateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E52A0 Offset: 0x26E12A0 VA: 0x26E52A0
	|-ReflectedPropertyBagProvider.CreateIndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E684C Offset: 0x26E284C VA: 0x26E684C
	|-ReflectedPropertyBagProvider.CreateSetPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E52F0 Offset: 0x26E12F0 VA: 0x26E52F0
	|-ReflectedPropertyBagProvider.CreateKeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E5340 Offset: 0x26E1340 VA: 0x26E5340
	|-ReflectedPropertyBagProvider.CreateKeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E51B0 Offset: 0x26E11B0 VA: 0x26E51B0
	|-ReflectedPropertyBagProvider.CreateArrayPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E5390 Offset: 0x26E1390 VA: 0x26E5390
	|-ReflectedPropertyBagProvider.CreateListPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E5250 Offset: 0x26E1250 VA: 0x26E5250
	|-ReflectedPropertyBagProvider.CreateHashSetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E5200 Offset: 0x26E1200 VA: 0x26E5200
	|-ReflectedPropertyBagProvider.CreateDictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(ReflectedPropertyBagProvider.<GetPropertyMembers>d__22))]
	// RVA: 0x3821A3C Offset: 0x381DA3C VA: 0x3821A3C
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x3821AEC Offset: 0x381DAEC VA: 0x3821AEC
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x3821C24 Offset: 0x381DC24 VA: 0x3821C24
	private static bool IsValidPropertyType(Type type) { }
}
