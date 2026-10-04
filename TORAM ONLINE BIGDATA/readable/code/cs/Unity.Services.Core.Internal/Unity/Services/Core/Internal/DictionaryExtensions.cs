// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
[Extension]
internal static class DictionaryExtensions // TypeDefIndex: 17594
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E81B8 Offset: 0x27E41B8 VA: 0x27E81B8
	|-DictionaryExtensions.MergeAllowOverride<object, int, object>
	|
	|-RVA: 0x27E852C Offset: 0x27E452C VA: 0x27E852C
	|-DictionaryExtensions.MergeAllowOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E8A38 Offset: 0x27E4A38 VA: 0x27E8A38
	|-DictionaryExtensions.ValueEquals<object, object>
	|
	|-RVA: 0x27E8A88 Offset: 0x27E4A88 VA: 0x27E8A88
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue, TComparer>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E8B00 Offset: 0x27E4B00 VA: 0x27E8B00
	|-DictionaryExtensions.ValueEquals<object, object, object>
	|
	|-RVA: 0x27E9028 Offset: 0x27E5028 VA: 0x27E9028
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}
