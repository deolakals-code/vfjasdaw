// Assembly: Newtonsoft.Json.dll
// Namespace: 
[Nullable(0)]
[IsReadOnly]
private struct DictionaryWrapper.DictionaryEnumerator<TKey, TValue, TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 15894
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 1 })]
	private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	[Nullable(2)]
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD090 Offset: 0x2DC9090 VA: 0x2DCD090
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD0F8 Offset: 0x2DC90F8 VA: 0x2DCD0F8
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD1C4 Offset: 0x2DC91C4 VA: 0x2DCD1C4
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD23C Offset: 0x2DC923C VA: 0x2DCD23C
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD2B4 Offset: 0x2DC92B4 VA: 0x2DCD2B4
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD6C4 Offset: 0x2DC96C4 VA: 0x2DCD6C4
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD764 Offset: 0x2DC9764 VA: 0x2DCD764
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}
