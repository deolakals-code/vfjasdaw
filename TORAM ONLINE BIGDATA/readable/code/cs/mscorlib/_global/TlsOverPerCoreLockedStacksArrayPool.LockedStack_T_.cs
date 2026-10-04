// Assembly: mscorlib.dll
// Namespace: 
private sealed class TlsOverPerCoreLockedStacksArrayPool.LockedStack<T> // TypeDefIndex: 10995
{
	// Fields
	private readonly T[][] _arrays; // 0x0
	private int _count; // 0x0
	private uint _firstStackItemMS; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public bool TryPush(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9DB18 Offset: 0x2B99B18 VA: 0x2B9DB18
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.TryPush
	|
	|-RVA: 0x2B9DF2C Offset: 0x2B99F2C VA: 0x2B9DF2C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.TryPush
	|
	|-RVA: 0x2B9E340 Offset: 0x2B9A340 VA: 0x2B9E340
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.TryPush
	|
	|-RVA: 0x2B9E754 Offset: 0x2B9A754 VA: 0x2B9E754
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.TryPush
	*/

	// RVA: -1 Offset: -1
	public T[] TryPop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9DC00 Offset: 0x2B99C00 VA: 0x2B9DC00
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.TryPop
	|
	|-RVA: 0x2B9E014 Offset: 0x2B9A014 VA: 0x2B9E014
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.TryPop
	|
	|-RVA: 0x2B9E428 Offset: 0x2B9A428 VA: 0x2B9E428
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.TryPop
	|
	|-RVA: 0x2B9E860 Offset: 0x2B9A860 VA: 0x2B9E860
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.TryPop
	*/

	// RVA: -1 Offset: -1
	public void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> pressure, int bucketSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9DC78 Offset: 0x2B99C78 VA: 0x2B9DC78
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.Trim
	|
	|-RVA: 0x2B9E08C Offset: 0x2B9A08C VA: 0x2B9E08C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.Trim
	|
	|-RVA: 0x2B9E4A0 Offset: 0x2B9A4A0 VA: 0x2B9E4A0
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.Trim
	|
	|-RVA: 0x2B9E8D8 Offset: 0x2B9A8D8 VA: 0x2B9E8D8
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9DED8 Offset: 0x2B99ED8 VA: 0x2B9DED8
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>..ctor
	|
	|-RVA: 0x2B9E2EC Offset: 0x2B9A2EC VA: 0x2B9E2EC
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>..ctor
	|
	|-RVA: 0x2B9E700 Offset: 0x2B9A700 VA: 0x2B9E700
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>..ctor
	|
	|-RVA: 0x2B9EB88 Offset: 0x2B9AB88 VA: 0x2B9EB88
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>..ctor
	*/
}
