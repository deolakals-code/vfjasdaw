// Assembly: mscorlib.dll
// Namespace: System.Buffers
internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T> // TypeDefIndex: 10996
{
	// Fields
	private readonly int[] _bucketArraySizes; // 0x0
	private readonly TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T>[] _buckets; // 0x0
	[ThreadStatic]
	private static T[][] t_tlsBuckets; // 0xFFFFFFFF
	private int _callbackCreated; // 0x0
	private static readonly bool s_trimBuffers; // 0x0
	private static readonly ConditionalWeakTable<T[][], object> s_allTlsBuckets; // 0x0

	// Properties
	private int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB670C Offset: 0x2CB270C VA: 0x2CB670C
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..ctor
	|
	|-RVA: 0x2CB7BDC Offset: 0x2CB3BDC VA: 0x2CB7BDC
	|-TlsOverPerCoreLockedStacksArrayPool<char>..ctor
	|
	|-RVA: 0x2CB90AC Offset: 0x2CB50AC VA: 0x2CB90AC
	|-TlsOverPerCoreLockedStacksArrayPool<int>..ctor
	|
	|-RVA: 0x2CBA57C Offset: 0x2CB657C VA: 0x2CBA57C
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB6818 Offset: 0x2CB2818 VA: 0x2CB6818
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x2CB7CE8 Offset: 0x2CB3CE8 VA: 0x2CB7CE8
	|-TlsOverPerCoreLockedStacksArrayPool<char>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x2CB91B8 Offset: 0x2CB51B8 VA: 0x2CB91B8
	|-TlsOverPerCoreLockedStacksArrayPool<int>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x2CBA68C Offset: 0x2CB668C VA: 0x2CBA68C
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.CreatePerCoreLockedStacks
	*/

	// RVA: -1 Offset: -1
	private int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB68AC Offset: 0x2CB28AC VA: 0x2CB68AC
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.get_Id
	|
	|-RVA: 0x2CB7D7C Offset: 0x2CB3D7C VA: 0x2CB7D7C
	|-TlsOverPerCoreLockedStacksArrayPool<char>.get_Id
	|
	|-RVA: 0x2CB924C Offset: 0x2CB524C VA: 0x2CB924C
	|-TlsOverPerCoreLockedStacksArrayPool<int>.get_Id
	|
	|-RVA: 0x2CBA724 Offset: 0x2CB6724 VA: 0x2CBA724
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.get_Id
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB68C8 Offset: 0x2CB28C8 VA: 0x2CB68C8
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Rent
	|
	|-RVA: 0x2CB7D98 Offset: 0x2CB3D98 VA: 0x2CB7D98
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Rent
	|
	|-RVA: 0x2CB9268 Offset: 0x2CB5268 VA: 0x2CB9268
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Rent
	|
	|-RVA: 0x2CBA740 Offset: 0x2CB6740 VA: 0x2CBA740
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB6C70 Offset: 0x2CB2C70 VA: 0x2CB6C70
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Return
	|
	|-RVA: 0x2CB8140 Offset: 0x2CB4140 VA: 0x2CB8140
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Return
	|
	|-RVA: 0x2CB9610 Offset: 0x2CB5610 VA: 0x2CB9610
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Return
	|
	|-RVA: 0x2CBAAC4 Offset: 0x2CB6AC4 VA: 0x2CBAAC4
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	public bool Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB7104 Offset: 0x2CB3104 VA: 0x2CB7104
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Trim
	|
	|-RVA: 0x2CB85D4 Offset: 0x2CB45D4 VA: 0x2CB85D4
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Trim
	|
	|-RVA: 0x2CB9AA4 Offset: 0x2CB5AA4 VA: 0x2CB9AA4
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Trim
	|
	|-RVA: 0x2CBAFBC Offset: 0x2CB6FBC VA: 0x2CBAFBC
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	private static bool Gen2GcCallbackFunc(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB7910 Offset: 0x2CB3910 VA: 0x2CB7910
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Gen2GcCallbackFunc
	|
	|-RVA: 0x2CB8DE0 Offset: 0x2CB4DE0 VA: 0x2CB8DE0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Gen2GcCallbackFunc
	|
	|-RVA: 0x2CBA2B0 Offset: 0x2CB62B0 VA: 0x2CBA2B0
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Gen2GcCallbackFunc
	|
	|-RVA: 0x2CBB878 Offset: 0x2CB7878 VA: 0x2CBB878
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Gen2GcCallbackFunc
	*/

	// RVA: -1 Offset: -1
	private static TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> GetMemoryPressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB79D8 Offset: 0x2CB39D8 VA: 0x2CB79D8
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetMemoryPressure
	|
	|-RVA: 0x2CB8EA8 Offset: 0x2CB4EA8 VA: 0x2CB8EA8
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetMemoryPressure
	|
	|-RVA: 0x2CBA378 Offset: 0x2CB6378 VA: 0x2CBA378
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetMemoryPressure
	|
	|-RVA: 0x2CBB978 Offset: 0x2CB7978 VA: 0x2CBB978
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetMemoryPressure
	*/

	// RVA: -1 Offset: -1
	private static bool GetTrimBuffers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB7A8C Offset: 0x2CB3A8C VA: 0x2CB7A8C
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetTrimBuffers
	|
	|-RVA: 0x2CB8F5C Offset: 0x2CB4F5C VA: 0x2CB8F5C
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetTrimBuffers
	|
	|-RVA: 0x2CBA42C Offset: 0x2CB642C VA: 0x2CBA42C
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetTrimBuffers
	|
	|-RVA: 0x2CBBA2C Offset: 0x2CB7A2C VA: 0x2CBBA2C
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetTrimBuffers
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB7A94 Offset: 0x2CB3A94 VA: 0x2CB7A94
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..cctor
	|
	|-RVA: 0x2CB8F64 Offset: 0x2CB4F64 VA: 0x2CB8F64
	|-TlsOverPerCoreLockedStacksArrayPool<char>..cctor
	|
	|-RVA: 0x2CBA434 Offset: 0x2CB6434 VA: 0x2CBA434
	|-TlsOverPerCoreLockedStacksArrayPool<int>..cctor
	|
	|-RVA: 0x2CBBA34 Offset: 0x2CB7A34 VA: 0x2CBBA34
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
