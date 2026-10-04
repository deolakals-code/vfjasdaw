// Assembly: Newtonsoft.Json.dll
// Namespace: 
[NullableContext(0)]
internal class DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable // TypeDefIndex: 15971
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 1 })]
	private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29630A8 Offset: 0x295F0A8 VA: 0x29630A8
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<KeyValuePair<object, object>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296311C Offset: 0x295F11C VA: 0x296311C
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2963198 Offset: 0x295F198 VA: 0x2963198
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
