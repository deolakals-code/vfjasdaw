// Assembly: System.Core.dll
// Namespace: 
[Serializable]
public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 15804
{
	// Fields
	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B968 Offset: 0x2967968 VA: 0x296B968
	|-HashSet.Enumerator<KeyValuePair<short, short>>..ctor
	|
	|-RVA: 0x296ED20 Offset: 0x296AD20 VA: 0x296ED20
	|-HashSet.Enumerator<byte>..ctor
	|
	|-RVA: 0x29712F8 Offset: 0x296D2F8 VA: 0x29712F8
	|-HashSet.Enumerator<int>..ctor
	|
	|-RVA: 0x29732E4 Offset: 0x296F2E4 VA: 0x29732E4
	|-HashSet.Enumerator<object>..ctor
	|
	|-RVA: 0x297780C Offset: 0x297380C VA: 0x297780C
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B9A0 Offset: 0x29679A0 VA: 0x296B9A0
	|-HashSet.Enumerator<KeyValuePair<short, short>>.Dispose
	|
	|-RVA: 0x296ED5C Offset: 0x296AD5C VA: 0x296ED5C
	|-HashSet.Enumerator<byte>.Dispose
	|
	|-RVA: 0x2971330 Offset: 0x296D330 VA: 0x2971330
	|-HashSet.Enumerator<int>.Dispose
	|
	|-RVA: 0x2973320 Offset: 0x296F320 VA: 0x2973320
	|-HashSet.Enumerator<object>.Dispose
	|
	|-RVA: 0x2977928 Offset: 0x2973928 VA: 0x2977928
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B9A4 Offset: 0x29679A4 VA: 0x296B9A4
	|-HashSet.Enumerator<KeyValuePair<short, short>>.MoveNext
	|
	|-RVA: 0x296ED60 Offset: 0x296AD60 VA: 0x296ED60
	|-HashSet.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x2971334 Offset: 0x296D334 VA: 0x2971334
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2973324 Offset: 0x296F324 VA: 0x2973324
	|-HashSet.Enumerator<object>.MoveNext
	|
	|-RVA: 0x297792C Offset: 0x297392C VA: 0x297792C
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BA94 Offset: 0x2967A94 VA: 0x296BA94
	|-HashSet.Enumerator<KeyValuePair<short, short>>.get_Current
	|
	|-RVA: 0x296EE50 Offset: 0x296AE50 VA: 0x296EE50
	|-HashSet.Enumerator<byte>.get_Current
	|
	|-RVA: 0x2971424 Offset: 0x296D424 VA: 0x2971424
	|-HashSet.Enumerator<int>.get_Current
	|
	|-RVA: 0x297341C Offset: 0x296F41C VA: 0x297341C
	|-HashSet.Enumerator<object>.get_Current
	|
	|-RVA: 0x2977D98 Offset: 0x2973D98 VA: 0x2977D98
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BA9C Offset: 0x2967A9C VA: 0x296BA9C
	|-HashSet.Enumerator<KeyValuePair<short, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296EE58 Offset: 0x296AE58 VA: 0x296EE58
	|-HashSet.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297142C Offset: 0x296D42C VA: 0x297142C
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2973424 Offset: 0x296F424 VA: 0x2973424
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2977E88 Offset: 0x2973E88 VA: 0x2977E88
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BB58 Offset: 0x2967B58 VA: 0x296BB58
	|-HashSet.Enumerator<KeyValuePair<short, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296EF14 Offset: 0x296AF14 VA: 0x296EF14
	|-HashSet.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29714E8 Offset: 0x296D4E8 VA: 0x29714E8
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29734B4 Offset: 0x296F4B4 VA: 0x29734B4
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2978094 Offset: 0x2974094 VA: 0x2978094
	|-HashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
