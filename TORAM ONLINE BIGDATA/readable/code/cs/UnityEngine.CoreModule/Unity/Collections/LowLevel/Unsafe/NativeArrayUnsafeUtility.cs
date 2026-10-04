// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
[Extension]
public static class NativeArrayUnsafeUtility // TypeDefIndex: 16185
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC958 Offset: 0x26D8958 VA: 0x26DC958
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x26DC964 Offset: 0x26D8964 VA: 0x26DC964
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|
	|-RVA: 0x26DC970 Offset: 0x26D8970 VA: 0x26DC970
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ContactPairHeader>
	|
	|-RVA: 0x26DC97C Offset: 0x26D897C VA: 0x26DC97C
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<CullingSplit>
	|
	|-RVA: 0x26DC988 Offset: 0x26D8988 VA: 0x26DC988
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|
	|-RVA: 0x26DC994 Offset: 0x26D8994 VA: 0x26DC994
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|
	|-RVA: 0x26DC9A0 Offset: 0x26D89A0 VA: 0x26DC9A0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>
	|
	|-RVA: 0x26DC9AC Offset: 0x26D89AC VA: 0x26DC9AC
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ModifiableContactPair>
	|
	|-RVA: 0x26DC9B8 Offset: 0x26D89B8 VA: 0x26DC9B8
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|
	|-RVA: 0x26DC9C4 Offset: 0x26D89C4 VA: 0x26DC9C4
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Quaternion>
	|
	|-RVA: 0x26DC9D0 Offset: 0x26D89D0 VA: 0x26DC9D0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<sbyte>
	|
	|-RVA: 0x26DC9DC Offset: 0x26D89DC VA: 0x26DC9DC
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3>
	|
	|-RVA: 0x26DC9E8 Offset: 0x26D89E8 VA: 0x26DC9E8
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC9F4 Offset: 0x26D89F4 VA: 0x26DC9F4
	|-NativeArrayUnsafeUtility.GetUnsafePtr<byte>
	|
	|-RVA: 0x26DC9F8 Offset: 0x26D89F8 VA: 0x26DC9F8
	|-NativeArrayUnsafeUtility.GetUnsafePtr<sbyte>
	|
	|-RVA: 0x26DC9FC Offset: 0x26D89FC VA: 0x26DC9FC
	|-NativeArrayUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DCA00 Offset: 0x26D8A00 VA: 0x26DCA00
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<byte>
	|
	|-RVA: 0x26DCA04 Offset: 0x26D8A04 VA: 0x26DCA04
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	*/
}
