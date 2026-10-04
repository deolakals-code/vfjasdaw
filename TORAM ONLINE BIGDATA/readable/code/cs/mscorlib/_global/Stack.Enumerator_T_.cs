// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
public struct Stack.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 10961
{
	// Fields
	private readonly Stack<T> _stack; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974050 Offset: 0x2970050 VA: 0x2974050
	|-Stack.Enumerator<object>..ctor
	|
	|-RVA: 0x297C300 Offset: 0x2978300 VA: 0x297C300
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x297E1A0 Offset: 0x297A1A0 VA: 0x297E1A0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x2980564 Offset: 0x297C564 VA: 0x2980564
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297408C Offset: 0x297008C VA: 0x297408C
	|-Stack.Enumerator<object>.Dispose
	|
	|-RVA: 0x297C41C Offset: 0x297841C VA: 0x297C41C
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x297E1E4 Offset: 0x297A1E4 VA: 0x297E1E4
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.Dispose
	|
	|-RVA: 0x29805A0 Offset: 0x297C5A0 VA: 0x29805A0
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974098 Offset: 0x2970098 VA: 0x2974098
	|-Stack.Enumerator<object>.MoveNext
	|
	|-RVA: 0x297C45C Offset: 0x297845C VA: 0x297C45C
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x297E1F0 Offset: 0x297A1F0 VA: 0x297E1F0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-RVA: 0x29805AC Offset: 0x297C5AC VA: 0x29805AC
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29741A8 Offset: 0x29701A8 VA: 0x29741A8
	|-Stack.Enumerator<object>.get_Current
	|
	|-RVA: 0x297C8A0 Offset: 0x29788A0 VA: 0x297C8A0
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x297E338 Offset: 0x297A338 VA: 0x297E338
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	|
	|-RVA: 0x29806D4 Offset: 0x297C6D4 VA: 0x29806D4
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29741E4 Offset: 0x29701E4 VA: 0x29741E4
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x297CA20 Offset: 0x2978A20 VA: 0x297CA20
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x297E380 Offset: 0x297A380 VA: 0x297E380
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2980714 Offset: 0x297C714 VA: 0x2980714
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974240 Offset: 0x2970240 VA: 0x2974240
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297CAB0 Offset: 0x2978AB0 VA: 0x297CAB0
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297E3DC Offset: 0x297A3DC VA: 0x297E3DC
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2980770 Offset: 0x297C770 VA: 0x2980770
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974274 Offset: 0x2970274 VA: 0x2974274
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297CBD4 Offset: 0x2978BD4 VA: 0x297CBD4
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297E460 Offset: 0x297A460 VA: 0x297E460
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29807E0 Offset: 0x297C7E0 VA: 0x29807E0
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEnumerator.Reset
	*/
}
