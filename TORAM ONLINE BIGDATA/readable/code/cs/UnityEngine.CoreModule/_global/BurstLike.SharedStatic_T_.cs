// Assembly: UnityEngine.CoreModule.dll
// Namespace: 
[IsReadOnly]
internal struct BurstLike.SharedStatic<T> // TypeDefIndex: 16168
{
	// Fields
	private readonly void* _buffer; // 0x0

	// Properties
	public T Data { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(void* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8F594 Offset: 0x2C8B594 VA: 0x2C8F594
	|-BurstLike.SharedStatic<IntPtr>..ctor
	|
	|-RVA: 0x2C8F5C4 Offset: 0x2C8B5C4 VA: 0x2C8F5C4
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8F59C Offset: 0x2C8B59C VA: 0x2C8F59C
	|-BurstLike.SharedStatic<IntPtr>.get_Data
	|
	|-RVA: 0x2C8F5CC Offset: 0x2C8B5CC VA: 0x2C8F5CC
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>.get_Data
	*/

	// RVA: -1 Offset: -1
	public static BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267BF98 Offset: 0x2677F98 VA: 0x267BF98
	|-BurstLike.SharedStatic<IntPtr>.GetOrCreate<IJobExtensions.JobStruct<NativeArrayDisposeJob>>
	|
	|-RVA: 0x267C01C Offset: 0x267801C VA: 0x267C01C
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate<__Il2CppFullySharedGenericType>
	*/
}
