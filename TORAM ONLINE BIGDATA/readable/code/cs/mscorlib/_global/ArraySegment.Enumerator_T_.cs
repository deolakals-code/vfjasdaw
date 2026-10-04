// Assembly: mscorlib.dll
// Namespace: 
public struct ArraySegment.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 9547
{
	// Fields
	private readonly T[] _array; // 0x0
	private readonly int _start; // 0x0
	private readonly int _end; // 0x0
	private int _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ArraySegment<T> arraySegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296EB3C Offset: 0x296AB3C VA: 0x296EB3C
	|-ArraySegment.Enumerator<byte>..ctor
	|
	|-RVA: 0x2977350 Offset: 0x2973350 VA: 0x2977350
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296EC20 Offset: 0x296AC20 VA: 0x296EC20
	|-ArraySegment.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x2977598 Offset: 0x2973598 VA: 0x2977598
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296EC48 Offset: 0x296AC48 VA: 0x296EC48
	|-ArraySegment.Enumerator<byte>.get_Current
	|
	|-RVA: 0x29775C0 Offset: 0x29735C0 VA: 0x29775C0
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296ECB0 Offset: 0x296ACB0 VA: 0x296ECB0
	|-ArraySegment.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29776D4 Offset: 0x29736D4 VA: 0x29776D4
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296ED0C Offset: 0x296AD0C VA: 0x296ED0C
	|-ArraySegment.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29777F8 Offset: 0x29737F8 VA: 0x29777F8
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296ED1C Offset: 0x296AD1C VA: 0x296ED1C
	|-ArraySegment.Enumerator<byte>.Dispose
	|
	|-RVA: 0x2977808 Offset: 0x2973808 VA: 0x2977808
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/
}
