// Assembly: mscorlib.dll
// Namespace: 
private sealed class TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T> // TypeDefIndex: 10994
{
	// Fields
	private readonly TlsOverPerCoreLockedStacksArrayPool.LockedStack<T>[] _perCoreStacks; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE193C Offset: 0x2BDD93C VA: 0x2BE193C
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>..ctor
	|
	|-RVA: 0x2BE1D48 Offset: 0x2BDDD48 VA: 0x2BE1D48
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>..ctor
	|
	|-RVA: 0x2BE2154 Offset: 0x2BDE154 VA: 0x2BE2154
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>..ctor
	|
	|-RVA: 0x2BE2560 Offset: 0x2BDE560 VA: 0x2BE2560
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void TryPush(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE1A90 Offset: 0x2BDDA90 VA: 0x2BE1A90
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>.TryPush
	|
	|-RVA: 0x2BE1E9C Offset: 0x2BDDE9C VA: 0x2BE1E9C
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>.TryPush
	|
	|-RVA: 0x2BE22A8 Offset: 0x2BDE2A8 VA: 0x2BE22A8
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>.TryPush
	|
	|-RVA: 0x2BE26B8 Offset: 0x2BDE6B8 VA: 0x2BE26B8
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>.TryPush
	*/

	// RVA: -1 Offset: -1
	public T[] TryPop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE1B68 Offset: 0x2BDDB68 VA: 0x2BE1B68
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>.TryPop
	|
	|-RVA: 0x2BE1F74 Offset: 0x2BDDF74 VA: 0x2BE1F74
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>.TryPop
	|
	|-RVA: 0x2BE2380 Offset: 0x2BDE380 VA: 0x2BE2380
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>.TryPop
	|
	|-RVA: 0x2BE2794 Offset: 0x2BDE794 VA: 0x2BE2794
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>.TryPop
	*/

	// RVA: -1 Offset: -1
	public bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> pressure, int[] bucketSizes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE1C90 Offset: 0x2BDDC90 VA: 0x2BE1C90
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>.Trim
	|
	|-RVA: 0x2BE209C Offset: 0x2BDE09C VA: 0x2BE209C
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>.Trim
	|
	|-RVA: 0x2BE24A8 Offset: 0x2BDE4A8 VA: 0x2BE24A8
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>.Trim
	|
	|-RVA: 0x2BE286C Offset: 0x2BDE86C VA: 0x2BE286C
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>.Trim
	*/
}
