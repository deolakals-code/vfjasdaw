// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class ImmutableCollectionsUtils // TypeDefIndex: 15931
{
	// Fields
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0x308FCF0 Offset: 0x308BCF0 VA: 0x308FCF0
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x30901E0 Offset: 0x308C1E0 VA: 0x30901E0
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x30906FC Offset: 0x308C6FC VA: 0x30906FC
	private static void .cctor() { }
}
