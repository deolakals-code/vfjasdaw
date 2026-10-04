// Assembly: System.dll
// Namespace: 
[Serializable]
internal sealed class SortedDictionary.KeyValuePairComparer<TKey, TValue> : Comparer<KeyValuePair<TKey, TValue>> // TypeDefIndex: 14324
{
	// Fields
	internal IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> keyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9C8A0 Offset: 0x2A988A0 VA: 0x2A9C8A0
	|-SortedDictionary.KeyValuePairComparer<byte, object>..ctor
	|
	|-RVA: 0x2A9C9A0 Offset: 0x2A989A0 VA: 0x2A9C9A0
	|-SortedDictionary.KeyValuePairComparer<double, int>..ctor
	|
	|-RVA: 0x2A9CAA0 Offset: 0x2A98AA0 VA: 0x2A9CAA0
	|-SortedDictionary.KeyValuePairComparer<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9C900 Offset: 0x2A98900 VA: 0x2A9C900
	|-SortedDictionary.KeyValuePairComparer<byte, object>.Compare
	|
	|-RVA: 0x2A9CA00 Offset: 0x2A98A00 VA: 0x2A9CA00
	|-SortedDictionary.KeyValuePairComparer<double, int>.Compare
	|
	|-RVA: 0x2A9CB08 Offset: 0x2A98B08 VA: 0x2A9CB08
	|-SortedDictionary.KeyValuePairComparer<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Compare
	*/
}
