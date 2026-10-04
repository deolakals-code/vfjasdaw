// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
public struct Queue.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 10958
{
	// Fields
	private readonly Queue<T> _q; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970888 Offset: 0x296C888 VA: 0x2970888
	|-Queue.Enumerator<DefencePoint2>..ctor
	|
	|-RVA: 0x297183C Offset: 0x296D83C VA: 0x297183C
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x2973C54 Offset: 0x296FC54 VA: 0x2973C54
	|-Queue.Enumerator<object>..ctor
	|
	|-RVA: 0x2979FA8 Offset: 0x2975FA8 VA: 0x2979FA8
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29708C4 Offset: 0x296C8C4 VA: 0x29708C4
	|-Queue.Enumerator<DefencePoint2>.Dispose
	|
	|-RVA: 0x2971878 Offset: 0x296D878 VA: 0x2971878
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x2973C90 Offset: 0x296FC90 VA: 0x2973C90
	|-Queue.Enumerator<object>.Dispose
	|
	|-RVA: 0x297A0C4 Offset: 0x29760C4 VA: 0x297A0C4
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29708D4 Offset: 0x296C8D4 VA: 0x29708D4
	|-Queue.Enumerator<DefencePoint2>.MoveNext
	|
	|-RVA: 0x2971888 Offset: 0x296D888 VA: 0x2971888
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2973CA0 Offset: 0x296FCA0 VA: 0x2973CA0
	|-Queue.Enumerator<object>.MoveNext
	|
	|-RVA: 0x297A174 Offset: 0x2976174 VA: 0x297A174
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29709C0 Offset: 0x296C9C0 VA: 0x29709C0
	|-Queue.Enumerator<DefencePoint2>.get_Current
	|
	|-RVA: 0x2971974 Offset: 0x296D974 VA: 0x2971974
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x2973D90 Offset: 0x296FD90 VA: 0x2973D90
	|-Queue.Enumerator<object>.get_Current
	|
	|-RVA: 0x297A518 Offset: 0x2976518 VA: 0x297A518
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29709FC Offset: 0x296C9FC VA: 0x29709FC
	|-Queue.Enumerator<DefencePoint2>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x29719B0 Offset: 0x296D9B0 VA: 0x29719B0
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2973DCC Offset: 0x296FDCC VA: 0x2973DCC
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x297A698 Offset: 0x2976698 VA: 0x297A698
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970A58 Offset: 0x296CA58 VA: 0x2970A58
	|-Queue.Enumerator<DefencePoint2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2971A0C Offset: 0x296DA0C VA: 0x2971A0C
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2973E28 Offset: 0x296FE28 VA: 0x2973E28
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297A728 Offset: 0x2976728 VA: 0x297A728
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970AC0 Offset: 0x296CAC0 VA: 0x2970AC0
	|-Queue.Enumerator<DefencePoint2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2971A74 Offset: 0x296DA74 VA: 0x2971A74
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2973E5C Offset: 0x296FE5C VA: 0x2973E5C
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297A84C Offset: 0x297684C VA: 0x297A84C
	|-Queue.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
