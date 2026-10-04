// Assembly: mscorlib.dll
// Namespace: 
private struct LowLevelListWithIList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 10967
{
	// Fields
	private LowLevelListWithIList<T> _list; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LowLevelListWithIList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973A1C Offset: 0x296FA1C VA: 0x2973A1C
	|-LowLevelListWithIList.Enumerator<object>..ctor
	|
	|-RVA: 0x2979624 Offset: 0x2975624 VA: 0x2979624
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973A58 Offset: 0x296FA58 VA: 0x2973A58
	|-LowLevelListWithIList.Enumerator<object>.Dispose
	|
	|-RVA: 0x2979740 Offset: 0x2975740 VA: 0x2979740
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973A5C Offset: 0x296FA5C VA: 0x2973A5C
	|-LowLevelListWithIList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x2979744 Offset: 0x2975744 VA: 0x2979744
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973AFC Offset: 0x296FAFC VA: 0x2973AFC
	|-LowLevelListWithIList.Enumerator<object>.MoveNextRare
	|
	|-RVA: 0x29799F0 Offset: 0x29759F0 VA: 0x29799F0
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.MoveNextRare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973B6C Offset: 0x296FB6C VA: 0x2973B6C
	|-LowLevelListWithIList.Enumerator<object>.get_Current
	|
	|-RVA: 0x2979B74 Offset: 0x2975B74 VA: 0x2979B74
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973B74 Offset: 0x296FB74 VA: 0x2973B74
	|-LowLevelListWithIList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2979C64 Offset: 0x2975C64 VA: 0x2979C64
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973BF0 Offset: 0x296FBF0 VA: 0x2973BF0
	|-LowLevelListWithIList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2979E5C Offset: 0x2975E5C VA: 0x2979E5C
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
