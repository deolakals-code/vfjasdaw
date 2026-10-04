// Assembly: mscorlib.dll
// Namespace: 
[CompilerGenerated]
private sealed class ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 10912
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public ConcurrentDictionary<TKey, TValue> <>4__this; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue>[] <buckets>5__2; // 0x0
	private int <i>5__3; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue> <current>5__4; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F680 Offset: 0x281B680 VA: 0x281F680
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x281F87C Offset: 0x281B87C VA: 0x281F87C
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>..ctor
	|
	|-RVA: 0x281FA58 Offset: 0x281BA58 VA: 0x281FA58
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F6A8 Offset: 0x281B6A8 VA: 0x281F6A8
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x281F8A4 Offset: 0x281B8A4 VA: 0x281F8A4
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x281FA98 Offset: 0x281BA98 VA: 0x281FA98
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F6AC Offset: 0x281B6AC VA: 0x281F6AC
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.MoveNext
	|
	|-RVA: 0x281F8A8 Offset: 0x281B8A8 VA: 0x281F8A8
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.MoveNext
	|
	|-RVA: 0x281FA9C Offset: 0x281BA9C VA: 0x281FA9C
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F7FC Offset: 0x281B7FC VA: 0x281F7FC
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x281F9E8 Offset: 0x281B9E8 VA: 0x281F9E8
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x281FF20 Offset: 0x281BF20 VA: 0x281FF20
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F810 Offset: 0x281B810 VA: 0x281F810
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281F9F4 Offset: 0x281B9F4 VA: 0x281F9F4
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281FFC0 Offset: 0x281BFC0 VA: 0x281FFC0
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F844 Offset: 0x281B844 VA: 0x281F844
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281FA28 Offset: 0x281BA28 VA: 0x281FA28
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281FFF4 Offset: 0x281BFF4 VA: 0x281FFF4
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}
